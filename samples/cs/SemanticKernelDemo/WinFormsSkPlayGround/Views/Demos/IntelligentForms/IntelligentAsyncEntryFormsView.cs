﻿using CommunityToolkit.WinForms.TypedInputExtenders;
using WinFormsSkPlayGround.Components;

namespace WinFormsSkPlayGround.Views;

[ToolboxBitmap(typeof(IntelligentAsyncEntryFormsView), "MvvmView.bmp")]
public partial class IntelligentAsyncEntryFormsView : UserControl
{
    private Form _parentForm;

    public IntelligentAsyncEntryFormsView(Form parentForm)
    {
        InitializeComponent();
        _parentForm = parentForm;

        if (Application.IsDarkModeEnabled)
        {
            // We need to manual color the background for dark mode for read-only textboxes.
            _txtAutomaticTripInfo.BackColor = Color.FromArgb(255, 10, 10, 10);
        }
    }

    private void AITripFormatter_ValueChanged(object sender, ValueChangedEventArgs<string> e)
    {
        var formatterSettings = (AITripFormatterComponent.AITripFormatter) e.SenderComponent.GetFormatterSettings((Control)sender)!;
        _txtAutomaticTripInfo.Text = formatterSettings.TripMetaData;
    }
}
