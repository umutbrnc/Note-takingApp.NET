namespace Intern_task_DT
{
    partial class myForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripTextBox});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(345, 39);
            this.menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.CheckOnClick = true;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 35);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.ShowShortcutKeys = false;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(93, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.ShowShortcutKeys = false;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(93, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(93, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.CheckOnClick = true;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectallToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShowShortcutKeys = false;
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 35);
            this.editToolStripMenuItem.Text = "E&dit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.ShowShortcutKeys = false;
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.ShowShortcutKeys = false;
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(123, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.ShowShortcutKeys = false;
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.ShowShortcutKeys = false;
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.ShowShortcutKeys = false;
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(123, 6);
            // 
            // selectallToolStripMenuItem
            // 
            this.selectallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectallToolStripMenuItem.Image")));
            this.selectallToolStripMenuItem.Name = "selectallToolStripMenuItem";
            this.selectallToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.selectallToolStripMenuItem.Text = "Select All";
            this.selectallToolStripMenuItem.Click += new System.EventHandler(this.selectallToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clearToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(49, 35);
            this.clearToolStripMenuItem.Text = "Clear ";
            this.clearToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripTextBox
            // 
            this.toolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox.AutoSize = false;
            this.toolStripTextBox.BackColor = System.Drawing.Color.Lavender;
            this.toolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.toolStripTextBox.Name = "toolStripTextBox";
            this.toolStripTextBox.Size = new System.Drawing.Size(100, 16);
            this.toolStripTextBox.Text = "  Search...";
            this.toolStripTextBox.Click += new System.EventHandler(this.toolStripTextBox_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(28, 35);
            this.searchToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.Color.Lavender;
            this.btnBold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBold.BackgroundImage")));
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Location = new System.Drawing.Point(12, 42);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(29, 26);
            this.btnBold.TabIndex = 2;
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.BackColor = System.Drawing.Color.Lavender;
            this.btnItalic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItalic.BackgroundImage")));
            this.btnItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.Location = new System.Drawing.Point(47, 42);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(29, 26);
            this.btnItalic.TabIndex = 3;
            this.btnItalic.UseVisualStyleBackColor = false;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.BackColor = System.Drawing.Color.Lavender;
            this.btnUnderline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnderline.BackgroundImage")));
            this.btnUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Location = new System.Drawing.Point(82, 42);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(29, 26);
            this.btnUnderline.TabIndex = 4;
            this.btnUnderline.UseVisualStyleBackColor = false;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Lavender;
            this.btnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColor.BackgroundImage")));
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(117, 42);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(29, 26);
            this.btnColor.TabIndex = 5;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtMain
            // 
            this.txtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain.BackColor = System.Drawing.Color.Lavender;
            this.txtMain.Location = new System.Drawing.Point(11, 74);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(322, 319);
            this.txtMain.TabIndex = 6;
            this.txtMain.Text = "";
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(345, 405);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.MediumPurple;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "myForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note-taking App @umutBirinci";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RichTextBox txtMain;
    }
}

