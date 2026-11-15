using System;
using System.Drawing;
using System.Windows.Forms;


namespace ScamJam.UI
{
    internal class CustomApplicationContext : TrayIconApplicationContext
    {
        #region Instance Fields


        private StatusWindow _status;
        protected StatusWindow Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private SettingsDialog _settings;
        private SettingsDialog Settings
        {
            get { return _settings; }
            set { _settings = value; }
        }

        #endregion

        #region Constructors

        public CustomApplicationContext()
        {
            this.TrayIcon.Icon = Properties.Resources.IconNeutral;

            this.ContextMenu.Items.Add("&Open Settings...", null, this.SettingsContextMenuClickHandler).Font = new Font(this.ContextMenu.Font, FontStyle.Bold);
            this.ContextMenu.Items.Add("-");
            this.ContextMenu.Items.Add("&Quit ScamJam", null, this.ExitContextMenuClickHandler);
        }

        #endregion

        #region Overridden Members

        protected override void OnTrayIconLeftClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Utilities.GetOpenFormInstance<StatusWindow>() is null)
                {
                    Status = new StatusWindow();
                    Status.Show();
                    Status.Activate();
                }
                else
                    Status.Dispose(); //What will this do?
            }

            base.OnTrayIconLeftClick(e);
        }

        #endregion

        #region Members

        private void ExitContextMenuClickHandler(object sender, EventArgs eventArgs)
        {
            this.ExitThread();
        }

        internal void SettingsContextMenuClickHandler(object sender, EventArgs eventArgs)
        {
            Status = new StatusWindow();
            Status.ShowSettings();
        }

        #endregion
    }
}
