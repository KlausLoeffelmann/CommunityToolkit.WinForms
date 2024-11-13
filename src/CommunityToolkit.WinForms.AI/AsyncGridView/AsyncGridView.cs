namespace CommunityToolkit.WinForms.AI.AsyncGridView;

public class AsyncGridView : Panel
{
    private AsyncDataGridView _dataGridView;

    public AsyncGridView()
    {
        _dataGridView = new AsyncDataGridView
        {
            Dock = DockStyle.Fill
        };

        Controls.Add(_dataGridView);
    }

    public int ColumnCount
    {
        get => _dataGridView.ColumnCount;
        set => _dataGridView.ColumnCount = value;
    }

    public Type? GridViewItemTemplate { get; set; }
}
