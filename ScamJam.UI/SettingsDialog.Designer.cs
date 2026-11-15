namespace ScamJam.UI
{
  partial class SettingsDialog
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            closeButton = new Button();
            settingsTabControl = new TabControl();
            contactsTabPage = new TabPage();
            addContactButton = new Button();
            removeContactButton = new Button();
            contactView = new ListView();
            emailConfiguredStatus = new Label();
            emailComboBox = new ComboBox();
            contactsSubtitle = new Label();
            contactsTitle = new Label();
            networkTabPage = new TabPage();
            networkAllowListGridView = new DataGridView();
            requestCategoryListBox = new CheckedListBox();
            networkSubtitle = new Label();
            networkTitle = new Label();
            scamTabPage = new TabPage();
            scamSubtitle = new Label();
            setPinButton = new Button();
            allowSystemToolsButton = new Button();
            dataGridView1 = new DataGridView();
            scamTitle = new Label();
            aboutTabPage = new TabPage();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            button1 = new Button();
            updateButton = new Button();
            dotnetVersionLabel = new Label();
            scamjamVersionLabel = new Label();
            aboutTitle = new Label();
            emailMenuStrip = new ContextMenuStrip(components);
            gmailToolStripMenuItem = new ToolStripMenuItem();
            iCloudToolStripMenuItem = new ToolStripMenuItem();
            outlookcomToolStripMenuItem = new ToolStripMenuItem();
            settingsTabControl.SuspendLayout();
            contactsTabPage.SuspendLayout();
            networkTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)networkAllowListGridView).BeginInit();
            scamTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            aboutTabPage.SuspendLayout();
            emailMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeButton.DialogResult = DialogResult.Cancel;
            closeButton.Location = new Point(933, 684);
            closeButton.Margin = new Padding(6, 7, 6, 7);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(229, 57);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // settingsTabControl
            // 
            settingsTabControl.Controls.Add(contactsTabPage);
            settingsTabControl.Controls.Add(networkTabPage);
            settingsTabControl.Controls.Add(scamTabPage);
            settingsTabControl.Controls.Add(aboutTabPage);
            settingsTabControl.Location = new Point(12, 12);
            settingsTabControl.Name = "settingsTabControl";
            settingsTabControl.SelectedIndex = 0;
            settingsTabControl.Size = new Size(1174, 662);
            settingsTabControl.TabIndex = 4;
            // 
            // contactsTabPage
            // 
            contactsTabPage.Controls.Add(addContactButton);
            contactsTabPage.Controls.Add(removeContactButton);
            contactsTabPage.Controls.Add(contactView);
            contactsTabPage.Controls.Add(emailConfiguredStatus);
            contactsTabPage.Controls.Add(emailComboBox);
            contactsTabPage.Controls.Add(contactsSubtitle);
            contactsTabPage.Controls.Add(contactsTitle);
            contactsTabPage.Location = new Point(8, 46);
            contactsTabPage.Name = "contactsTabPage";
            contactsTabPage.Padding = new Padding(3);
            contactsTabPage.Size = new Size(1158, 608);
            contactsTabPage.TabIndex = 1;
            contactsTabPage.Text = "Trusted Contacts";
            contactsTabPage.UseVisualStyleBackColor = true;
            // 
            // addContactButton
            // 
            addContactButton.Font = new Font("Segoe Fluent Icons", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addContactButton.Location = new Point(996, 500);
            addContactButton.Name = "addContactButton";
            addContactButton.Size = new Size(52, 46);
            addContactButton.TabIndex = 6;
            addContactButton.Text = "";
            addContactButton.UseVisualStyleBackColor = true;
            // 
            // removeContactButton
            // 
            removeContactButton.Font = new Font("Segoe Fluent Icons", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeContactButton.Location = new Point(1054, 500);
            removeContactButton.Name = "removeContactButton";
            removeContactButton.Size = new Size(52, 46);
            removeContactButton.TabIndex = 5;
            removeContactButton.Text = "";
            removeContactButton.UseVisualStyleBackColor = true;
            // 
            // contactView
            // 
            contactView.Location = new Point(615, 251);
            contactView.Name = "contactView";
            contactView.Size = new Size(491, 243);
            contactView.TabIndex = 4;
            contactView.UseCompatibleStateImageBehavior = false;
            // 
            // emailConfiguredStatus
            // 
            emailConfiguredStatus.AutoSize = true;
            emailConfiguredStatus.ForeColor = Color.Firebrick;
            emailConfiguredStatus.Location = new Point(407, 255);
            emailConfiguredStatus.Name = "emailConfiguredStatus";
            emailConfiguredStatus.Size = new Size(181, 32);
            emailConfiguredStatus.TabIndex = 3;
            emailConfiguredStatus.Text = "Not Configured";
            // 
            // emailComboBox
            // 
            emailComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            emailComboBox.FormattingEnabled = true;
            emailComboBox.Items.AddRange(new object[] { "Choose your email provider...", "Gmail", "iCloud Mail", "Outlook.com" });
            emailComboBox.Location = new Point(59, 251);
            emailComboBox.Name = "emailComboBox";
            emailComboBox.Size = new Size(335, 40);
            emailComboBox.TabIndex = 2;
            // 
            // contactsSubtitle
            // 
            contactsSubtitle.AutoSize = true;
            contactsSubtitle.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactsSubtitle.Location = new Point(49, 139);
            contactsSubtitle.Name = "contactsSubtitle";
            contactsSubtitle.Size = new Size(664, 64);
            contactsSubtitle.TabIndex = 1;
            contactsSubtitle.Text = "Configure ScamJam to send email alerts to trusted contacts\r\nwhen you are at risk of being scammed.";
            // 
            // contactsTitle
            // 
            contactsTitle.AutoSize = true;
            contactsTitle.Font = new Font("Segoe UI Variable Display Semib", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactsTitle.Location = new Point(49, 57);
            contactsTitle.Name = "contactsTitle";
            contactsTitle.Size = new Size(358, 57);
            contactsTitle.TabIndex = 0;
            contactsTitle.Text = "Trusted Contacts";
            // 
            // networkTabPage
            // 
            networkTabPage.Controls.Add(networkAllowListGridView);
            networkTabPage.Controls.Add(requestCategoryListBox);
            networkTabPage.Controls.Add(networkSubtitle);
            networkTabPage.Controls.Add(networkTitle);
            networkTabPage.Location = new Point(8, 46);
            networkTabPage.Name = "networkTabPage";
            networkTabPage.Padding = new Padding(3);
            networkTabPage.Size = new Size(1158, 608);
            networkTabPage.TabIndex = 2;
            networkTabPage.Text = "Network Settings";
            networkTabPage.UseVisualStyleBackColor = true;
            // 
            // networkAllowListGridView
            // 
            networkAllowListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            networkAllowListGridView.Location = new Point(716, 252);
            networkAllowListGridView.Name = "networkAllowListGridView";
            networkAllowListGridView.RowHeadersWidth = 82;
            networkAllowListGridView.Size = new Size(409, 300);
            networkAllowListGridView.TabIndex = 5;
            // 
            // requestCategoryListBox
            // 
            requestCategoryListBox.FormattingEnabled = true;
            requestCategoryListBox.Items.AddRange(new object[] { "Block domains belonging to remote access services", "Block known scams and malware", "Block malicious popups", "Block dynamic DNS services", "Block DNS rebinding", "Block commonly abused top level domains", "Block domains registered in the past 14 days" });
            requestCategoryListBox.Location = new Point(49, 252);
            requestCategoryListBox.Name = "requestCategoryListBox";
            requestCategoryListBox.Size = new Size(634, 256);
            requestCategoryListBox.TabIndex = 4;
            // 
            // networkSubtitle
            // 
            networkSubtitle.AutoSize = true;
            networkSubtitle.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkSubtitle.Location = new Point(49, 139);
            networkSubtitle.Name = "networkSubtitle";
            networkSubtitle.Size = new Size(596, 32);
            networkSubtitle.TabIndex = 3;
            networkSubtitle.Text = "Choose the network requests ScamJam should block.";
            // 
            // networkTitle
            // 
            networkTitle.AutoSize = true;
            networkTitle.Font = new Font("Segoe UI Variable Display Semib", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkTitle.Location = new Point(49, 57);
            networkTitle.Name = "networkTitle";
            networkTitle.Size = new Size(585, 57);
            networkTitle.TabIndex = 2;
            networkTitle.Text = "Network Protection Settings";
            // 
            // scamTabPage
            // 
            scamTabPage.Controls.Add(scamSubtitle);
            scamTabPage.Controls.Add(setPinButton);
            scamTabPage.Controls.Add(allowSystemToolsButton);
            scamTabPage.Controls.Add(dataGridView1);
            scamTabPage.Controls.Add(scamTitle);
            scamTabPage.Location = new Point(8, 46);
            scamTabPage.Name = "scamTabPage";
            scamTabPage.Padding = new Padding(3);
            scamTabPage.Size = new Size(1158, 608);
            scamTabPage.TabIndex = 3;
            scamTabPage.Text = "Scam Protection Settings";
            scamTabPage.UseVisualStyleBackColor = true;
            // 
            // scamSubtitle
            // 
            scamSubtitle.AutoSize = true;
            scamSubtitle.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scamSubtitle.Location = new Point(49, 143);
            scamSubtitle.Name = "scamSubtitle";
            scamSubtitle.Size = new Size(529, 32);
            scamSubtitle.TabIndex = 8;
            scamSubtitle.Text = "Choose which software ScamJam should block.";
            // 
            // setPinButton
            // 
            setPinButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            setPinButton.DialogResult = DialogResult.Cancel;
            setPinButton.Location = new Point(435, 529);
            setPinButton.Margin = new Padding(6, 7, 6, 7);
            setPinButton.Name = "setPinButton";
            setPinButton.Size = new Size(176, 57);
            setPinButton.TabIndex = 7;
            setPinButton.Text = "Set safety PIN";
            setPinButton.UseVisualStyleBackColor = true;
            // 
            // allowSystemToolsButton
            // 
            allowSystemToolsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            allowSystemToolsButton.DialogResult = DialogResult.Cancel;
            allowSystemToolsButton.Location = new Point(49, 529);
            allowSystemToolsButton.Margin = new Padding(6, 7, 6, 7);
            allowSystemToolsButton.Name = "allowSystemToolsButton";
            allowSystemToolsButton.Size = new Size(351, 57);
            allowSystemToolsButton.TabIndex = 5;
            allowSystemToolsButton.Text = "Temporarily allow system tools";
            allowSystemToolsButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1136, 300);
            dataGridView1.TabIndex = 6;
            // 
            // scamTitle
            // 
            scamTitle.AutoSize = true;
            scamTitle.Font = new Font("Segoe UI Variable Display Semib", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scamTitle.Location = new Point(49, 57);
            scamTitle.Name = "scamTitle";
            scamTitle.Size = new Size(523, 57);
            scamTitle.TabIndex = 4;
            scamTitle.Text = "Scam Protection Settings";
            // 
            // aboutTabPage
            // 
            aboutTabPage.Controls.Add(button2);
            aboutTabPage.Controls.Add(linkLabel1);
            aboutTabPage.Controls.Add(label1);
            aboutTabPage.Controls.Add(button1);
            aboutTabPage.Controls.Add(updateButton);
            aboutTabPage.Controls.Add(dotnetVersionLabel);
            aboutTabPage.Controls.Add(scamjamVersionLabel);
            aboutTabPage.Controls.Add(aboutTitle);
            aboutTabPage.Location = new Point(8, 46);
            aboutTabPage.Name = "aboutTabPage";
            aboutTabPage.Padding = new Padding(3);
            aboutTabPage.Size = new Size(1158, 608);
            aboutTabPage.TabIndex = 4;
            aboutTabPage.Text = "About ScamJam";
            aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(581, 477);
            button2.Margin = new Padding(6, 7, 6, 7);
            button2.Name = "button2";
            button2.Size = new Size(464, 57);
            button2.TabIndex = 12;
            button2.Text = "Open Source Software Acknowledgments";
            button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(947, 403);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(145, 32);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "View it here.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(535, 371);
            label1.Name = "label1";
            label1.Size = new Size(557, 64);
            label1.TabIndex = 9;
            label1.Text = "ScamJam is made available under the terms of the\r\nGNU General Public License version 3.";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(91, 477);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(229, 57);
            button1.TabIndex = 8;
            button1.Text = "Open log files";
            button1.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateButton.Location = new Point(91, 375);
            updateButton.Margin = new Padding(6, 7, 6, 7);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(229, 57);
            updateButton.TabIndex = 5;
            updateButton.Text = "Check for updates";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // dotnetVersionLabel
            // 
            dotnetVersionLabel.AutoSize = true;
            dotnetVersionLabel.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dotnetVersionLabel.Location = new Point(67, 172);
            dotnetVersionLabel.Name = "dotnetVersionLabel";
            dotnetVersionLabel.Size = new Size(277, 32);
            dotnetVersionLabel.TabIndex = 7;
            dotnetVersionLabel.Text = "DotNet version ERROR!!!";
            // 
            // scamjamVersionLabel
            // 
            scamjamVersionLabel.AutoSize = true;
            scamjamVersionLabel.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scamjamVersionLabel.Location = new Point(57, 128);
            scamjamVersionLabel.Name = "scamjamVersionLabel";
            scamjamVersionLabel.Size = new Size(296, 32);
            scamjamVersionLabel.TabIndex = 6;
            scamjamVersionLabel.Text = "ScamJam version ERROR!!!";
            // 
            // aboutTitle
            // 
            aboutTitle.AutoSize = true;
            aboutTitle.Font = new Font("Segoe UI Variable Display Semib", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutTitle.Location = new Point(33, 57);
            aboutTitle.Name = "aboutTitle";
            aboutTitle.Size = new Size(344, 57);
            aboutTitle.TabIndex = 4;
            aboutTitle.Text = "About ScamJam";
            // 
            // emailMenuStrip
            // 
            emailMenuStrip.Font = new Font("Segoe UI", 9F);
            emailMenuStrip.ImageScalingSize = new Size(32, 32);
            emailMenuStrip.Items.AddRange(new ToolStripItem[] { gmailToolStripMenuItem, iCloudToolStripMenuItem, outlookcomToolStripMenuItem });
            emailMenuStrip.Name = "emailMenuStrip";
            emailMenuStrip.Size = new Size(226, 118);
            // 
            // gmailToolStripMenuItem
            // 
            gmailToolStripMenuItem.Name = "gmailToolStripMenuItem";
            gmailToolStripMenuItem.Size = new Size(225, 38);
            gmailToolStripMenuItem.Text = "Gmail";
            // 
            // iCloudToolStripMenuItem
            // 
            iCloudToolStripMenuItem.Name = "iCloudToolStripMenuItem";
            iCloudToolStripMenuItem.Size = new Size(225, 38);
            iCloudToolStripMenuItem.Text = "iCloud";
            // 
            // outlookcomToolStripMenuItem
            // 
            outlookcomToolStripMenuItem.Name = "outlookcomToolStripMenuItem";
            outlookcomToolStripMenuItem.Size = new Size(225, 38);
            outlookcomToolStripMenuItem.Text = "Outlook.com";
            // 
            // SettingsDialog
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 770);
            Controls.Add(settingsTabControl);
            Controls.Add(closeButton);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            settingsTabControl.ResumeLayout(false);
            contactsTabPage.ResumeLayout(false);
            contactsTabPage.PerformLayout();
            networkTabPage.ResumeLayout(false);
            networkTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)networkAllowListGridView).EndInit();
            scamTabPage.ResumeLayout(false);
            scamTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            aboutTabPage.ResumeLayout(false);
            aboutTabPage.PerformLayout();
            emailMenuStrip.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label contactsTitle;
    private System.Windows.Forms.Button okButton;
        private Button closeButton;
        private TabControl settingsTabControl;
        private TabPage contactsTabPage;
        private TabPage networkTabPage;
        private TabPage scamTabPage;
        private TabPage aboutTabPage;
        private Label contactsSubtitle;
        private ContextMenuStrip emailMenuStrip;
        private ToolStripMenuItem gmailToolStripMenuItem;
        private ToolStripMenuItem iCloudToolStripMenuItem;
        private ToolStripMenuItem outlookcomToolStripMenuItem;
        private ComboBox emailComboBox;
        private Label emailConfiguredStatus;
        private ListView contactView;
        private Button removeContactButton;
        private Button addContactButton;
        private Label networkSubtitle;
        private Label networkTitle;
        private CheckedListBox requestCategoryListBox;
        private DataGridView networkAllowListGridView;
        private Label scamSubtitle;
        private Label scamTitle;
        private DataGridView dataGridView1;
        private Button setPinButton;
        private Button allowSystemToolsButton;
        private Label aboutTitle;
        private Label scamjamVersionLabel;
        private Button updateButton;
        private Label dotnetVersionLabel;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button button2;
    }
}

