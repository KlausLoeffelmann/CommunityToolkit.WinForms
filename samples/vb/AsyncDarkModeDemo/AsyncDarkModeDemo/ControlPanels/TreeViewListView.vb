Public Class TreeViewListView

    Sub New()
        InitializeComponent()
        ' Set the ListView to details view
        _lvwElements.View = View.Details
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        SetupTreeView()
        ReportViewDemo()
    End Sub

    Public Sub SetupTreeView()
        _tvwMenu.Nodes.Clear()

        ' Insert 50 random LOB App pretend menu-items into the TreeView:
        Dim rootNode As TreeNode

        ' Serious Tax Consulting Menu Items
        rootNode = _tvwMenu.Nodes.Add("Client Management")
        rootNode.Nodes.Add("Add New Client")
        rootNode.Nodes.Add("Update Client Information")
        rootNode.Nodes.Add("View Client History")
        rootNode.Nodes.Add("Archive Client")

        rootNode = _tvwMenu.Nodes.Add("Tax Forms")
        rootNode.Nodes.Add("Generate Tax Form")
        rootNode.Nodes.Add("Import Tax Form Data")
        rootNode.Nodes.Add("Export Tax Form")
        rootNode.Nodes.Add("Print Tax Form")

        rootNode = _tvwMenu.Nodes.Add("Financial Reports")
        rootNode.Nodes.Add("Monthly Report")
        rootNode.Nodes.Add("Quarterly Report")
        rootNode.Nodes.Add("Annual Report")
        rootNode.Nodes.Add("Custom Report")

        rootNode = _tvwMenu.Nodes.Add("Compliance")
        rootNode.Nodes.Add("Check Compliance Status")
        rootNode.Nodes.Add("Update Compliance Rules")
        rootNode.Nodes.Add("Audit Trail")
        rootNode.Nodes.Add("Submit Compliance Report")

        rootNode = _tvwMenu.Nodes.Add("Billing")
        rootNode.Nodes.Add("Generate Invoice")
        rootNode.Nodes.Add("Send Invoice")
        rootNode.Nodes.Add("View Payment History")
        rootNode.Nodes.Add("Manage Payment Methods")

        ' Fun and Creative Menu Items
        rootNode = _tvwMenu.Nodes.Add("Big Bang Theory References")
        Dim subNode As TreeNode

        subNode = rootNode.Nodes.Add("Sheldon")
        subNode.Nodes.Add("Bazinga Counter")
        subNode.Nodes.Add("Roommate Agreement")
        subNode.Nodes.Add("Spot Reservation")

        subNode = rootNode.Nodes.Add("Leonard")
        subNode.Nodes.Add("Laser Experiment Log")
        subNode.Nodes.Add("Penny Interaction Tracker")

        subNode = rootNode.Nodes.Add("Howard")
        subNode.Nodes.Add("Mars Rover Control")
        subNode.Nodes.Add("Mother's Calls Log")

        subNode = rootNode.Nodes.Add("Raj")
        subNode.Nodes.Add("Astrophysics Simulations")
        subNode.Nodes.Add("Canine Compatibility Chart")

        rootNode = _tvwMenu.Nodes.Add("Dr. House References")
        subNode = rootNode.Nodes.Add("Diagnostics")
        subNode.Nodes.Add("Lupus Checklist")
        subNode.Nodes.Add("Vicodin Supply Tracker")
        subNode.Nodes.Add("Duckling Notes")

        subNode = rootNode.Nodes.Add("Patient Management")
        subNode.Nodes.Add("Mysterious Illness Log")
        subNode.Nodes.Add("Snarky Comments Archive")

        rootNode = _tvwMenu.Nodes.Add("Star Wars References")
        subNode = rootNode.Nodes.Add("Jedi Training")
        subNode.Nodes.Add("Lightsaber Calibration")
        subNode.Nodes.Add("Force Sensitivity Test")

        subNode = rootNode.Nodes.Add("Empire Management")
        subNode.Nodes.Add("Death Star Plans")
        subNode.Nodes.Add("Stormtrooper Accuracy Training")
        subNode.Nodes.Add("Sith Lord Locator")

        rootNode = _tvwMenu.Nodes.Add("Miscellaneous Fun")
        subNode = rootNode.Nodes.Add("Random")
        subNode.Nodes.Add("Enable Unicorn Mode")
        subNode.Nodes.Add("Start Coffee Maker")
        subNode.Nodes.Add("Order Pizza")
        subNode.Nodes.Add("Open Portal to Another Dimension")

        subNode = rootNode.Nodes.Add("Easter Eggs")
        subNode.Nodes.Add("Secret Mode")
        subNode.Nodes.Add("Developer's Favorite Jokes")

        subNode = rootNode.Nodes.Add("Experimental Features")
        subNode.Nodes.Add("AI Code Completion")
        subNode.Nodes.Add("VR Mode")
        subNode.Nodes.Add("Holographic Display")
    End Sub

    Private Sub ReportViewDemo()
        _lvwElements.Items.Clear()

        _lvwElements.FullRowSelect = True

        ' Add column headers
        _lvwElements.Columns.Add("Report ID", 80, HorizontalAlignment.Left)
        _lvwElements.Columns.Add("Client Name", 150, HorizontalAlignment.Left)
        _lvwElements.Columns.Add("Consultation Date", 120, HorizontalAlignment.Left)
        _lvwElements.Columns.Add("Amount", 100, HorizontalAlignment.Right)
        _lvwElements.Columns.Add("Description", 200, HorizontalAlignment.Left)

        ' Define a pool of creative text items
        Dim funnyItems As New List(Of String) From {
        "Unexpected Unicorn Expenses",
        "Mystery Deductions",
        "Invisible Income Adjustments",
        "Alien Invasion Write-Offs",
        "Time Travel Tax Break",
        "Zombie Apocalypse Insurance",
        "Dragon Egg Valuation",
        "Wizard's Consultation Fee",
        "Potion Ingredients Tax",
        "Fairy Tale Royalty Payments"
    }

        ' Insert 500 funny items into the ListView
        Dim random As New Random()
        For i As Integer = 1 To 500
            Dim item As New ListViewItem($"ID-{i:D3}")
            item.SubItems.Add($"Client {random.Next(1000, 9999)}")
            item.SubItems.Add(DateTime.Now.AddDays(-random.Next(0, 365)).ToShortDateString())
            item.SubItems.Add($"{random.Next(100, 10000):C2}")
            item.SubItems.Add(funnyItems(random.Next(funnyItems.Count)))
            _lvwElements.Items.Add(item)
        Next
    End Sub

End Class
