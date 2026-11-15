using System;
using System.Data;
using System.Windows.Forms;

namespace ScamJam.UI
{
    public partial class SettingsDialog : Form
    {
        #region Constructors

        public SettingsDialog()
        {
            InitializeComponent();
            DataSet settings = new DataSet();
            emailComboBox.SelectedItem = "Choose your email provider...";
        }

        private BindingSource _bs = new BindingSource();
        //if empty, show placeholder text.
        #endregion

        #region Overridden Members

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.Activate();
        }

        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
