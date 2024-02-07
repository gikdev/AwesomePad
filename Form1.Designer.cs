namespace Awesome
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemView = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.itemColorBg = new System.Windows.Forms.ToolStripMenuItem();
            this.itemColorText = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThemeDark = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThemeLight = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThemeHacker = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThemeJoker = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dialogColorBg = new System.Windows.Forms.ColorDialog();
            this.dialogColorText = new System.Windows.Forms.ColorDialog();
            this.dialogFont = new System.Windows.Forms.FontDialog();
            this.dialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.dialogSave = new System.Windows.Forms.SaveFileDialog();
            this.itemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpen,
            this.itemSave,
            this.itemSaveAs,
            this.toolStripMenuItem2,
            this.itemExit});
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(37, 20);
            this.itemFile.Text = "File";
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(180, 22);
            this.itemOpen.Text = "Open";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // itemSave
            // 
            this.itemSave.Name = "itemSave";
            this.itemSave.Size = new System.Drawing.Size(180, 22);
            this.itemSave.Text = "Save";
            this.itemSave.Click += new System.EventHandler(this.itemSave_Click);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(180, 22);
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemUndo});
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(39, 20);
            this.itemEdit.Text = "Edit";
            // 
            // itemUndo
            // 
            this.itemUndo.Enabled = false;
            this.itemUndo.Name = "itemUndo";
            this.itemUndo.Size = new System.Drawing.Size(180, 22);
            this.itemUndo.Text = "Undo";
            // 
            // itemView
            // 
            this.itemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemWordWrap,
            this.itemFont,
            this.itemColorBg,
            this.itemColorText,
            this.itemTheme});
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(44, 20);
            this.itemView.Text = "View";
            // 
            // itemWordWrap
            // 
            this.itemWordWrap.Name = "itemWordWrap";
            this.itemWordWrap.Size = new System.Drawing.Size(180, 22);
            this.itemWordWrap.Text = "Word Wrap";
            this.itemWordWrap.Click += new System.EventHandler(this.itemWordWrap_Click);
            // 
            // itemFont
            // 
            this.itemFont.Name = "itemFont";
            this.itemFont.Size = new System.Drawing.Size(180, 22);
            this.itemFont.Text = "Font";
            this.itemFont.Click += new System.EventHandler(this.itemFont_Click);
            // 
            // itemColorBg
            // 
            this.itemColorBg.Enabled = false;
            this.itemColorBg.Name = "itemColorBg";
            this.itemColorBg.Size = new System.Drawing.Size(180, 22);
            this.itemColorBg.Text = "Background Color";
            // 
            // itemColorText
            // 
            this.itemColorText.Enabled = false;
            this.itemColorText.Name = "itemColorText";
            this.itemColorText.Size = new System.Drawing.Size(180, 22);
            this.itemColorText.Text = "Text Color";
            // 
            // itemTheme
            // 
            this.itemTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemThemeDark,
            this.itemThemeLight,
            this.itemThemeHacker,
            this.itemThemeJoker});
            this.itemTheme.Name = "itemTheme";
            this.itemTheme.Size = new System.Drawing.Size(180, 22);
            this.itemTheme.Text = "Theme";
            // 
            // itemThemeDark
            // 
            this.itemThemeDark.Name = "itemThemeDark";
            this.itemThemeDark.Size = new System.Drawing.Size(180, 22);
            this.itemThemeDark.Text = "Dark";
            this.itemThemeDark.Click += new System.EventHandler(this.itemThemeDark_Click);
            // 
            // itemThemeLight
            // 
            this.itemThemeLight.Name = "itemThemeLight";
            this.itemThemeLight.Size = new System.Drawing.Size(180, 22);
            this.itemThemeLight.Text = "Light";
            this.itemThemeLight.Click += new System.EventHandler(this.itemThemeLight_Click);
            // 
            // itemThemeHacker
            // 
            this.itemThemeHacker.Name = "itemThemeHacker";
            this.itemThemeHacker.Size = new System.Drawing.Size(180, 22);
            this.itemThemeHacker.Text = "Hacker";
            this.itemThemeHacker.Click += new System.EventHandler(this.itemThemeHacker_Click);
            // 
            // itemThemeJoker
            // 
            this.itemThemeJoker.Name = "itemThemeJoker";
            this.itemThemeJoker.Size = new System.Drawing.Size(180, 22);
            this.itemThemeJoker.Text = "Joker";
            this.itemThemeJoker.Click += new System.EventHandler(this.itemThemeJoker_Click);
            // 
            // itemHelp
            // 
            this.itemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAbout});
            this.itemHelp.Name = "itemHelp";
            this.itemHelp.Size = new System.Drawing.Size(44, 20);
            this.itemHelp.Text = "Help";
            // 
            // itemAbout
            // 
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(182, 22);
            this.itemAbout.Text = "About AwesomePad";
            this.itemAbout.Click += new System.EventHandler(this.itemAbout_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemEdit,
            this.itemView,
            this.itemHelp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(784, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dialogOpen
            // 
            this.dialogOpen.FileName = "openFileDialog1";
            this.dialogOpen.Title = "Select a file to edit:";
            // 
            // dialogSave
            // 
            this.dialogSave.Title = "Where to save your file?";
            // 
            // itemSaveAs
            // 
            this.itemSaveAs.Enabled = false;
            this.itemSaveAs.Name = "itemSaveAs";
            this.itemSaveAs.Size = new System.Drawing.Size(180, 22);
            this.itemSaveAs.Text = "Save as";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // txtMain
            // 
            this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.Location = new System.Drawing.Point(0, 24);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(784, 437);
            this.txtMain.TabIndex = 2;
            this.txtMain.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AwesomePad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemSave;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripMenuItem itemUndo;
        private System.Windows.Forms.ToolStripMenuItem itemView;
        private System.Windows.Forms.ToolStripMenuItem itemWordWrap;
        private System.Windows.Forms.ToolStripMenuItem itemFont;
        private System.Windows.Forms.ToolStripMenuItem itemColorBg;
        private System.Windows.Forms.ToolStripMenuItem itemColorText;
        private System.Windows.Forms.ToolStripMenuItem itemTheme;
        private System.Windows.Forms.ToolStripMenuItem itemThemeDark;
        private System.Windows.Forms.ToolStripMenuItem itemThemeLight;
        private System.Windows.Forms.ToolStripMenuItem itemThemeHacker;
        private System.Windows.Forms.ToolStripMenuItem itemThemeJoker;
        private System.Windows.Forms.ToolStripMenuItem itemHelp;
        private System.Windows.Forms.ToolStripMenuItem itemAbout;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ColorDialog dialogColorBg;
        private System.Windows.Forms.ColorDialog dialogColorText;
        private System.Windows.Forms.FontDialog dialogFont;
        private System.Windows.Forms.OpenFileDialog dialogOpen;
        private System.Windows.Forms.SaveFileDialog dialogSave;
        private System.Windows.Forms.ToolStripMenuItem itemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.RichTextBox txtMain;
    }
}

