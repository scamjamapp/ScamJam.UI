
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScamJam.UI
{
    public partial class StatusWindow : Form
    {
        #region Constructors

        public StatusWindow()
        {
            InitializeComponent();

        }

        #endregion

        #region Overridden Members

        protected override void OnLoad(EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - this.Width, Screen.PrimaryScreen.WorkingArea.Bottom - this.Height);

            base.OnLoad(e);
        }

        #endregion

        private SettingsDialog _settings;
        private SettingsDialog Settings
        {
            get { return _settings; }
            set { _settings = value; }
        }


        internal void ShowSettings()
        {
            if (Utilities.GetOpenFormInstance<StatusWindow>() is not null)
            {
                Dispose();
            }
            if (Utilities.GetOpenFormInstance<SettingsDialog>() is null)
            {
                using (Settings = new SettingsDialog())
                    Settings.ShowDialog();
            }
            else
            {
                var s = Utilities.GetOpenFormInstance<SettingsDialog>();
                if (s is not null)
                {
                    s.Activate();
                }
            }
        }

        private void openSettingsButton_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }
    }
}
