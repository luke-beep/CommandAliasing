using System.ComponentModel;
using CommandAliasing.Helpers;
using CommandAliasing.Models;

namespace CommandAliasing;

public partial class Main : Form
{
    private readonly BindingList<MacroItem> _macros = [];

    public Main()
    {
        InitializeComponent();
        LoadMacros();
        SetupContextMenu();
        UpdateStatus();

        // Universal error handler
        AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
        {
            MessageBox.Show($@"An unhandled exception occurred: {args.ExceptionObject}", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        };

        FormClosing += (sender, args) =>
        {
            if (MacroHelper.GetMacros() == _macros.ToDictionary(m => m.Alias, m => m.Command)) return;
            var result = MessageBox.Show(@"You have unsaved changes. Do you want to save them?", @"Unsaved Changes",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    SaveButtonClick(sender, args);
                    break;
                case DialogResult.Cancel:
                    args.Cancel = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        };
    }

    private void InstallButtonClick(object sender, EventArgs e)
    {
        if (MacroHelper.IsInstalled())
        {
            MessageBox.Show(@"Already installed", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var key = MacroHelper.Install();
        MessageBox.Show($@"Successfully installed persistent macros to {key}", @"Success", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        UpdateStatus();
    }

    private void UninstallButtonClick(object sender, EventArgs e)
    {
        if (!MacroHelper.IsInstalled())
        {
            MessageBox.Show(@"Not installed", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var key = MacroHelper.Uninstall();
        MessageBox.Show($@"Successfully uninstalled persistent macros from {key}", @"Success", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        UpdateStatus();
    }

    private void LoadMacros()
    {
        _macros.Clear();
        try
        {
            var macroDict = MacroHelper.GetMacros();
            foreach (var item in macroDict)
                _macros.Add(new MacroItem { Alias = item.Key, Command = item.Value });

            MacroView.DataSource = _macros;
        }
        catch (Exception ex)
        {
            MessageBox.Show($@"Failed to load macros: {ex.Message}", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void SetupContextMenu()
    {
        var menu = new ContextMenuStrip();
        menu.Items.Add("Remove", null, RemoveMacro);
        menu.BackColor = Color.FromArgb(0xECEFF4);
        menu.ForeColor = Color.FromArgb(0x2E3440);
        MacroView.ContextMenuStrip = menu;
    }

    private void RemoveMacro(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in MacroView.SelectedRows)
            if (row.DataBoundItem is MacroItem item)
                _macros.Remove(item);
    }

    private void SaveButtonClick(object sender, EventArgs e)
    {
        try
        {
            MacroHelper.UpdateMacros(_macros.ToDictionary(m => m.Alias, m => m.Command));
            MessageBox.Show(@"Successfully saved macros", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateStatus();
        }
        catch (Exception ex)
        {
            MessageBox.Show($@"Failed to save macros: {ex.Message}", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void RefreshButtonClick(object sender, EventArgs e)
    {
        LoadMacros();
        UpdateStatus();
    }

    private void UpdateStatus()
    {
        Text = $@"CA - {(MacroHelper.IsInstalled() ? "Installed" : "Not Installed")} - {_macros.Count} Macros";
    }
}