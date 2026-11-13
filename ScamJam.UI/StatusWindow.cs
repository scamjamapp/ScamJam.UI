
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

            //checkBox1 = ToggleOnButtonClickCheckBox;




        }

        #endregion

        #region Overridden Members

        protected override void OnLoad(EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - this.Width, Screen.PrimaryScreen.WorkingArea.Bottom - this.Height);

            base.OnLoad(e);
        }

        #endregion

    }
}
