using System.ComponentModel;

namespace CommunityToolkit.WinForms.ModernTabControl;

public partial class ModernTabControl : Panel
{
    private readonly MenuStrip _menuStrip;   // Tab bar
    private readonly List<Panel> _tabPages;  // Tab pages
    private ToolStripMenuItem? _currentItem;

    public event EventHandler? TabChanged;

    public ModernTabControl()
    {
        _menuStrip = new MenuStrip
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            Renderer = new RoundedCornersRenderer(),
            Font = new Font("Segoe UI", 12, FontStyle.Regular)
        };

        _tabPages = new List<Panel>();

        Controls.Add(_menuStrip);
    }

    protected override void OnLayout(LayoutEventArgs layoutEventArgs)
    {
        base.OnLayout(layoutEventArgs);

        foreach (var page in _tabPages)
        {
            page.Width = ClientSize.Width;
            page.Height = ClientSize.Height - _menuStrip.Height;
            page.Location = new Point(0, _menuStrip.Height);
            page.Padding = new Padding(3, 25, 3, 3);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int CurrentTabIndex
    {
        get => _menuStrip
            .Items
            .IndexOf(_menuStrip.Items
            .OfType<ToolStripMenuItem>()
            .First(i => i.Checked));

        set
        {
            foreach (var item in _menuStrip.Items.OfType<ToolStripMenuItem>())
            {
                item.Checked = item == _menuStrip.Items[value];
            }

            foreach (var page in _tabPages)
            {
                page.Visible = page == _tabPages[value];
            }
        }
    }

    public Control? CurrentTab
    {
        get => _tabPages is null || _tabPages.Count == 0
            ? null
            : _tabPages[CurrentTabIndex].Controls[0];
    }

    public void AddTab(string tabPageTitle, ContainerControl tabContent)
    {
        var tabPage = new Panel
        {
            Dock = DockStyle.Fill,
            Visible = false,
            BorderStyle = BorderStyle.None
        };

        tabContent.Dock = DockStyle.Fill;
        tabPage.Controls.Add(tabContent);
        _tabPages.Add(tabPage);

        var tabItem = new ToolStripMenuItem(tabPageTitle)
        {
            CheckOnClick = true,
            AutoSize = true,
            Padding = new Padding(20, 5, 10, 5)
        };

        tabItem.Click += (sender, e) =>
        {
            // If the clicked item is selected, nothing changes.
            if (sender is not ToolStripMenuItem senderItem
                || senderItem == _currentItem)
            {
                return;
            }

            _currentItem = senderItem;

            foreach (var item in _menuStrip.Items.OfType<ToolStripMenuItem>())
            {
                item.Checked = item == sender;
            }

            foreach (var page in _tabPages)
            {
                page.Visible = page == tabPage;
            }

            OnTabChanged(EventArgs.Empty);
        };

        _menuStrip.Items.Add(tabItem);
        Controls.Add(tabPage);

        // Select the first tab by default if this is the first tab added
        if (_menuStrip.Items.Count == 1)
        {
            CurrentTabIndex = 0;
        }
    }

    protected virtual void OnTabChanged(EventArgs empty) 
        => TabChanged?.Invoke(this, empty);
}
