namespace ScamJam.UI
{
  partial class StatusWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            Title = new Label();
            kryptonToggleSwitch1 = new Krypton.Toolkit.KryptonToggleSwitch();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-42, 200);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Display Semib", 16F, FontStyle.Bold);
            label3.Location = new Point(101, 500);
            label3.Name = "label3";
            label3.Size = new Size(428, 57);
            label3.TabIndex = 3;
            label3.Text = "ScamJam is disabled";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(185, 698);
            button1.Name = "button1";
            button1.Size = new Size(261, 64);
            button1.TabIndex = 4;
            button1.Text = "Open Settings";
            button1.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Segoe UI Variable Display Semib", 30F, FontStyle.Bold);
            Title.Location = new Point(120, 100);
            Title.Name = "Title";
            Title.Size = new Size(391, 106);
            Title.TabIndex = 1;
            Title.Text = "ScamJam";
            // 
            // kryptonToggleSwitch1
            // 
            kryptonToggleSwitch1.Location = new Point(131, 285);
            kryptonToggleSwitch1.Name = "kryptonToggleSwitch1";
            kryptonToggleSwitch1.Size = new Size(369, 140);
            kryptonToggleSwitch1.TabIndex = 5;
            // 
            // StatusWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 855);
            Controls.Add(kryptonToggleSwitch1);
            Controls.Add(button1);
            Controls.Add(Title);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 7, 6, 7);
            Name = "StatusWindow";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "ScamJam";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Label label3;
        private Button button1;
        private Label Title;
        private Label label2;
        private Krypton.Toolkit.KryptonToggleSwitch kryptonToggleSwitch1;
    }
}