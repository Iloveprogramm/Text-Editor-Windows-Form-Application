
namespace SimpleTextEditor
{
    partial class TextEditorSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorSC));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewButtonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.OpenButtonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.SaveButtonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.SaveAsToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BoldButtonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ItalicsToolStrip = new System.Windows.Forms.ToolStripButton();
            this.UnderLineToolStrip = new System.Windows.Forms.ToolStripButton();
            this.FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.UserTypeAndName = new System.Windows.Forms.ToolStripLabel();
            this.UserNameAndType = new System.Windows.Forms.ToolStripLabel();
            this.AboutStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UserTypetoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.CutbuttonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.CopyButtonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.PastebuttonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New  ";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open   ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save     ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut       ";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy    ";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste   ";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButtonToolStrip,
            this.OpenButtonToolStrip,
            this.SaveButtonToolStrip,
            this.SaveAsToolStrip,
            this.toolStripSeparator1,
            this.BoldButtonToolStrip,
            this.ItalicsToolStrip,
            this.UnderLineToolStrip,
            this.FontSize,
            this.UserTypeAndName,
            this.UserNameAndType,
            this.AboutStripButton,
            this.toolStripSeparator2,
            this.UserTypetoolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewButtonToolStrip
            // 
            this.NewButtonToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButtonToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("NewButtonToolStrip.Image")));
            this.NewButtonToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButtonToolStrip.Name = "NewButtonToolStrip";
            this.NewButtonToolStrip.Size = new System.Drawing.Size(23, 22);
            this.NewButtonToolStrip.Text = "toolStripButton1";
            this.NewButtonToolStrip.ToolTipText = "New ";
            this.NewButtonToolStrip.Click += new System.EventHandler(this.NewButtonToolStrip_Click);
            // 
            // OpenButtonToolStrip
            // 
            this.OpenButtonToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButtonToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("OpenButtonToolStrip.Image")));
            this.OpenButtonToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButtonToolStrip.Name = "OpenButtonToolStrip";
            this.OpenButtonToolStrip.Size = new System.Drawing.Size(23, 22);
            this.OpenButtonToolStrip.Text = "toolStripButton2";
            this.OpenButtonToolStrip.ToolTipText = "open";
            this.OpenButtonToolStrip.Click += new System.EventHandler(this.OpenButtonToolStrip_Click);
            // 
            // SaveButtonToolStrip
            // 
            this.SaveButtonToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButtonToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveButtonToolStrip.Image")));
            this.SaveButtonToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButtonToolStrip.Name = "SaveButtonToolStrip";
            this.SaveButtonToolStrip.Size = new System.Drawing.Size(23, 22);
            this.SaveButtonToolStrip.Text = "toolStripButton3";
            this.SaveButtonToolStrip.ToolTipText = "save";
            this.SaveButtonToolStrip.Click += new System.EventHandler(this.SaveButtonToolStrip_Click);
            // 
            // SaveAsToolStrip
            // 
            this.SaveAsToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsToolStrip.Image")));
            this.SaveAsToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsToolStrip.Name = "SaveAsToolStrip";
            this.SaveAsToolStrip.Size = new System.Drawing.Size(23, 22);
            this.SaveAsToolStrip.Text = "toolStripButton4";
            this.SaveAsToolStrip.ToolTipText = "save-as";
            this.SaveAsToolStrip.Click += new System.EventHandler(this.SaveAsToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BoldButtonToolStrip
            // 
            this.BoldButtonToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldButtonToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("BoldButtonToolStrip.Image")));
            this.BoldButtonToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldButtonToolStrip.Name = "BoldButtonToolStrip";
            this.BoldButtonToolStrip.Size = new System.Drawing.Size(23, 22);
            this.BoldButtonToolStrip.Text = "toolStripButton5";
            this.BoldButtonToolStrip.ToolTipText = "bold";
            this.BoldButtonToolStrip.Click += new System.EventHandler(this.BoldButtonToolStrip_Click);
            // 
            // ItalicsToolStrip
            // 
            this.ItalicsToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicsToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ItalicsToolStrip.Image")));
            this.ItalicsToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicsToolStrip.Name = "ItalicsToolStrip";
            this.ItalicsToolStrip.Size = new System.Drawing.Size(23, 22);
            this.ItalicsToolStrip.Text = "toolStripButton6";
            this.ItalicsToolStrip.ToolTipText = "italics";
            this.ItalicsToolStrip.Click += new System.EventHandler(this.ItalicsToolStrip_Click);
            // 
            // UnderLineToolStrip
            // 
            this.UnderLineToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderLineToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("UnderLineToolStrip.Image")));
            this.UnderLineToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderLineToolStrip.Name = "UnderLineToolStrip";
            this.UnderLineToolStrip.Size = new System.Drawing.Size(23, 22);
            this.UnderLineToolStrip.Text = "toolStripButton7";
            this.UnderLineToolStrip.ToolTipText = "underline";
            this.UnderLineToolStrip.Click += new System.EventHandler(this.UnderLineToolStrip_Click);
            // 
            // FontSize
            // 
            this.FontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(121, 25);
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // UserTypeAndName
            // 
            this.UserTypeAndName.Name = "UserTypeAndName";
            this.UserTypeAndName.Size = new System.Drawing.Size(0, 22);
            // 
            // UserNameAndType
            // 
            this.UserNameAndType.Name = "UserNameAndType";
            this.UserNameAndType.Size = new System.Drawing.Size(0, 22);
            // 
            // AboutStripButton
            // 
            this.AboutStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutStripButton.Image")));
            this.AboutStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutStripButton.Name = "AboutStripButton";
            this.AboutStripButton.Size = new System.Drawing.Size(23, 22);
            this.AboutStripButton.Text = "toolStripButton1";
            this.AboutStripButton.Click += new System.EventHandler(this.AboutStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // UserTypetoolStripLabel
            // 
            this.UserTypetoolStripLabel.Name = "UserTypetoolStripLabel";
            this.UserTypetoolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutbuttonToolStrip,
            this.CopyButtonToolStrip,
            this.PastebuttonToolStrip});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 401);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // CutbuttonToolStrip
            // 
            this.CutbuttonToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutbuttonToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CutbuttonToolStrip.Image")));
            this.CutbuttonToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutbuttonToolStrip.Name = "CutbuttonToolStrip";
            this.CutbuttonToolStrip.Size = new System.Drawing.Size(21, 20);
            this.CutbuttonToolStrip.Text = "toolStripButton9";
            this.CutbuttonToolStrip.ToolTipText = "cut";
            this.CutbuttonToolStrip.Click += new System.EventHandler(this.CutbuttonToolStrip_Click);
            // 
            // CopyButtonToolStrip
            // 
            this.CopyButtonToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyButtonToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CopyButtonToolStrip.Image")));
            this.CopyButtonToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyButtonToolStrip.Name = "CopyButtonToolStrip";
            this.CopyButtonToolStrip.Size = new System.Drawing.Size(21, 20);
            this.CopyButtonToolStrip.Text = "toolStripButton10";
            this.CopyButtonToolStrip.ToolTipText = "Copy";
            this.CopyButtonToolStrip.Click += new System.EventHandler(this.CopyButtonToolStrip_Click);
            // 
            // PastebuttonToolStrip
            // 
            this.PastebuttonToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PastebuttonToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("PastebuttonToolStrip.Image")));
            this.PastebuttonToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PastebuttonToolStrip.Name = "PastebuttonToolStrip";
            this.PastebuttonToolStrip.Size = new System.Drawing.Size(21, 20);
            this.PastebuttonToolStrip.Text = "toolStripButton11";
            this.PastebuttonToolStrip.ToolTipText = "Paste";
            this.PastebuttonToolStrip.Click += new System.EventHandler(this.PastebuttonToolStrip_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(27, 52);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(711, 367);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // TextEditorSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditorSC";
            this.Text = "TextEditorSC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewButtonToolStrip;
        private System.Windows.Forms.ToolStripButton OpenButtonToolStrip;
        private System.Windows.Forms.ToolStripButton SaveButtonToolStrip;
        private System.Windows.Forms.ToolStripButton SaveAsToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BoldButtonToolStrip;
        private System.Windows.Forms.ToolStripButton ItalicsToolStrip;
        private System.Windows.Forms.ToolStripButton UnderLineToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton CutbuttonToolStrip;
        private System.Windows.Forms.ToolStripButton CopyButtonToolStrip;
        private System.Windows.Forms.ToolStripButton PastebuttonToolStrip;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripLabel UserTypeAndName;
        private System.Windows.Forms.ToolStripComboBox FontSize;
        private System.Windows.Forms.ToolStripLabel UserNameAndType;
        private System.Windows.Forms.ToolStripButton AboutStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel UserTypetoolStripLabel;
    }
}