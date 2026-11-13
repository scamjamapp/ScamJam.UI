using System;
using System.Drawing;
using System.Windows.Forms;


namespace ScamJam.UI
{
  internal class CustomApplicationContext : TrayIconApplicationContext
  {
    #region Instance Fields

    private settingsDialog _settingsDialog;

    private StatusWindow _statusWindow;

    #endregion

    #region Constructors

    public CustomApplicationContext()
    {
      this.TrayIcon.Icon = Properties.Resources.IconNeutral;

      this.ContextMenu.Items.Add("&Settings...", null, this.SettingsContextMenuClickHandler).Font = new Font(this.ContextMenu.Font, FontStyle.Bold);
      this.ContextMenu.Items.Add("-");
      this.ContextMenu.Items.Add("&Quit ScamJam", null, this.ExitContextMenuClickHandler);
    }

    #endregion

    #region Overridden Members

    protected override void OnTrayIconClick(MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        if (_statusWindow == null || _statusWindow.IsDisposed == true)
        {
          _statusWindow = new StatusWindow();
          _statusWindow.Show();
          _statusWindow.Activate();
        }
        else
          this.HideStatusWindow();
      }

      base.OnTrayIconClick(e);
    }

    protected override void OnTrayIconDoubleClick(MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
        this.ShowSettings();

      base.OnTrayIconDoubleClick(e);
    }

    #endregion

    #region Members

    private void ExitContextMenuClickHandler(object sender, EventArgs eventArgs)
    {
      this.ExitThread();
    }


    private void HideStatusWindow()
    {
      if (_statusWindow is not null)
      {
        _statusWindow.Dispose();
        _statusWindow = null;
      }
    }

    private void SettingsContextMenuClickHandler(object sender, EventArgs eventArgs)
    {
      this.ShowSettings();
    }

    private void ShowSettings()
    {
      this.HideStatusWindow();

      if (_settingsDialog == null)
      {
        using (_settingsDialog = new settingsDialog())
          _settingsDialog.ShowDialog();
        _settingsDialog = null;
      }
      else
        _settingsDialog.Activate();
    }

    #endregion
  }
}
