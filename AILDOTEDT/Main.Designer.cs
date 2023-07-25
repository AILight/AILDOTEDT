namespace AILDOTEDT
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip = new StatusStrip();
            tableLayoutPanelTop = new TableLayoutPanel();
            toolStripCommand = new ToolStrip();
            toolStripButton_New = new ToolStripButton();
            toolStripButton_Open = new ToolStripButton();
            toolStripButton_Save = new ToolStripButton();
            toolStripButton_Print = new ToolStripButton();
            toolStripSeparator_File = new ToolStripSeparator();
            toolStripButton_Cut = new ToolStripButton();
            toolStripButton_Copy = new ToolStripButton();
            toolStripButton_Paste = new ToolStripButton();
            toolStripSeparator_Edit = new ToolStripSeparator();
            toolStripButton_Help = new ToolStripButton();
            toolStripContent = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripButton();
            menuStrip = new MenuStrip();
            toolStripMenuItem_File = new ToolStripMenuItem();
            toolStripMenuItem_New = new ToolStripMenuItem();
            toolStripMenuItem_Open = new ToolStripMenuItem();
            toolStripSeparator_FileMenu = new ToolStripSeparator();
            toolStripMenuItem_Save = new ToolStripMenuItem();
            toolStripMenuItem_SaveAs = new ToolStripMenuItem();
            toolStripSeparator_SaveMenu = new ToolStripSeparator();
            toolStripMenuItem_Print = new ToolStripMenuItem();
            toolStripMenuItem_PrintPreview = new ToolStripMenuItem();
            toolStripSeparator_PrintMenu = new ToolStripSeparator();
            toolStripMenuItem_Exit = new ToolStripMenuItem();
            toolStripMenuItem_Edit = new ToolStripMenuItem();
            toolStripMenuItem_Undo = new ToolStripMenuItem();
            toolStripMenuItem_Redo = new ToolStripMenuItem();
            toolStripSeparator_UndoMenu = new ToolStripSeparator();
            toolStripMenuItem_Cut = new ToolStripMenuItem();
            toolStripMenuItem_Copy = new ToolStripMenuItem();
            toolStripMenuItem_Paste = new ToolStripMenuItem();
            toolStripSeparator_CAPMenu = new ToolStripSeparator();
            toolStripMenuItem_SelectAll = new ToolStripMenuItem();
            toolStripMenuItem_Tool = new ToolStripMenuItem();
            toolStripMenuItem_Customize = new ToolStripMenuItem();
            toolStripMenuItem_Option = new ToolStripMenuItem();
            toolStripMenuItem_Help = new ToolStripMenuItem();
            toolStripMenuItem_OpenHelp = new ToolStripMenuItem();
            toolStripSeparator_HelpMenu = new ToolStripSeparator();
            toolStripMenuItem_About = new ToolStripMenuItem();
            picMain = new PictureBox();
            tableLayoutPanelTop.SuspendLayout();
            toolStripCommand.SuspendLayout();
            toolStripContent.SuspendLayout();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Location = new Point(0, 707);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1207, 22);
            statusStrip.TabIndex = 10;
            statusStrip.Text = "statusStrip1";
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.BackColor = SystemColors.Control;
            tableLayoutPanelTop.ColumnCount = 2;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.61806F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.38194F));
            tableLayoutPanelTop.Controls.Add(toolStripCommand, 0, 1);
            tableLayoutPanelTop.Controls.Add(toolStripContent, 0, 0);
            tableLayoutPanelTop.Controls.Add(menuStrip, 0, 0);
            tableLayoutPanelTop.Dock = DockStyle.Top;
            tableLayoutPanelTop.Location = new Point(0, 0);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 2;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.Size = new Size(1207, 49);
            tableLayoutPanelTop.TabIndex = 15;
            // 
            // toolStripCommand
            // 
            tableLayoutPanelTop.SetColumnSpan(toolStripCommand, 2);
            toolStripCommand.Items.AddRange(new ToolStripItem[] { toolStripButton_New, toolStripButton_Open, toolStripButton_Save, toolStripButton_Print, toolStripSeparator_File, toolStripButton_Cut, toolStripButton_Copy, toolStripButton_Paste, toolStripSeparator_Edit, toolStripButton_Help });
            toolStripCommand.Location = new Point(0, 24);
            toolStripCommand.Name = "toolStripCommand";
            toolStripCommand.Size = new Size(1207, 25);
            toolStripCommand.TabIndex = 18;
            toolStripCommand.Text = "toolStrip1";
            // 
            // toolStripButton_New
            // 
            toolStripButton_New.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_New.Image = (Image)resources.GetObject("toolStripButton_New.Image");
            toolStripButton_New.ImageTransparentColor = Color.Magenta;
            toolStripButton_New.Name = "toolStripButton_New";
            toolStripButton_New.Size = new Size(23, 22);
            toolStripButton_New.Text = "新規(&N)";
            toolStripButton_New.Click += toolStripMenuItem_New_Click;
            // 
            // toolStripButton_Open
            // 
            toolStripButton_Open.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Open.Image = (Image)resources.GetObject("toolStripButton_Open.Image");
            toolStripButton_Open.ImageTransparentColor = Color.Magenta;
            toolStripButton_Open.Name = "toolStripButton_Open";
            toolStripButton_Open.Size = new Size(23, 22);
            toolStripButton_Open.Text = "開く(&O)";
            // 
            // toolStripButton_Save
            // 
            toolStripButton_Save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Save.Image = (Image)resources.GetObject("toolStripButton_Save.Image");
            toolStripButton_Save.ImageTransparentColor = Color.Magenta;
            toolStripButton_Save.Name = "toolStripButton_Save";
            toolStripButton_Save.Size = new Size(23, 22);
            toolStripButton_Save.Text = "保存(&S)";
            // 
            // toolStripButton_Print
            // 
            toolStripButton_Print.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Print.Image = (Image)resources.GetObject("toolStripButton_Print.Image");
            toolStripButton_Print.ImageTransparentColor = Color.Magenta;
            toolStripButton_Print.Name = "toolStripButton_Print";
            toolStripButton_Print.Size = new Size(23, 22);
            toolStripButton_Print.Text = "印刷(&P)";
            // 
            // toolStripSeparator_File
            // 
            toolStripSeparator_File.Name = "toolStripSeparator_File";
            toolStripSeparator_File.Size = new Size(6, 25);
            // 
            // toolStripButton_Cut
            // 
            toolStripButton_Cut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Cut.Image = (Image)resources.GetObject("toolStripButton_Cut.Image");
            toolStripButton_Cut.ImageTransparentColor = Color.Magenta;
            toolStripButton_Cut.Name = "toolStripButton_Cut";
            toolStripButton_Cut.Size = new Size(23, 22);
            toolStripButton_Cut.Text = "切り取り(&U)";
            // 
            // toolStripButton_Copy
            // 
            toolStripButton_Copy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Copy.Image = (Image)resources.GetObject("toolStripButton_Copy.Image");
            toolStripButton_Copy.ImageTransparentColor = Color.Magenta;
            toolStripButton_Copy.Name = "toolStripButton_Copy";
            toolStripButton_Copy.Size = new Size(23, 22);
            toolStripButton_Copy.Text = "コピー(&C)";
            // 
            // toolStripButton_Paste
            // 
            toolStripButton_Paste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Paste.Image = (Image)resources.GetObject("toolStripButton_Paste.Image");
            toolStripButton_Paste.ImageTransparentColor = Color.Magenta;
            toolStripButton_Paste.Name = "toolStripButton_Paste";
            toolStripButton_Paste.Size = new Size(23, 22);
            toolStripButton_Paste.Text = "貼り付け(&P)";
            // 
            // toolStripSeparator_Edit
            // 
            toolStripSeparator_Edit.Name = "toolStripSeparator_Edit";
            toolStripSeparator_Edit.Size = new Size(6, 25);
            // 
            // toolStripButton_Help
            // 
            toolStripButton_Help.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Help.Image = (Image)resources.GetObject("toolStripButton_Help.Image");
            toolStripButton_Help.ImageTransparentColor = Color.Magenta;
            toolStripButton_Help.Name = "toolStripButton_Help";
            toolStripButton_Help.Size = new Size(23, 22);
            toolStripButton_Help.Text = "ヘルプ(&L)";
            // 
            // toolStripContent
            // 
            toolStripContent.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator3, toolStripLabel1 });
            toolStripContent.Location = new Point(272, 0);
            toolStripContent.Name = "toolStripContent";
            toolStripContent.Size = new Size(935, 24);
            toolStripContent.TabIndex = 14;
            toolStripContent.Text = "toolStrip2";
            toolStripContent.ItemClicked += toolStripContent_ItemClicked;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Checked = true;
            toolStripButton1.CheckState = CheckState.Checked;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(63, 21);
            toolStripButton1.Text = "マップパーツ";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 24);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.ImageTransparentColor = Color.Magenta;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(62, 21);
            toolStripLabel1.Text = "オブジェクト";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_File, toolStripMenuItem_Edit, toolStripMenuItem_Tool, toolStripMenuItem_Help });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(272, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "aaaa";
            // 
            // toolStripMenuItem_File
            // 
            toolStripMenuItem_File.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_New, toolStripMenuItem_Open, toolStripSeparator_FileMenu, toolStripMenuItem_Save, toolStripMenuItem_SaveAs, toolStripSeparator_SaveMenu, toolStripMenuItem_Print, toolStripMenuItem_PrintPreview, toolStripSeparator_PrintMenu, toolStripMenuItem_Exit });
            toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            toolStripMenuItem_File.Size = new Size(67, 20);
            toolStripMenuItem_File.Text = "ファイル(&F)";
            // 
            // toolStripMenuItem_New
            // 
            toolStripMenuItem_New.Image = (Image)resources.GetObject("toolStripMenuItem_New.Image");
            toolStripMenuItem_New.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem_New.Name = "toolStripMenuItem_New";
            toolStripMenuItem_New.Size = new Size(177, 22);
            toolStripMenuItem_New.Text = "新規(&N)";
            toolStripMenuItem_New.Click += toolStripMenuItem_New_Click;
            // 
            // toolStripMenuItem_Open
            // 
            toolStripMenuItem_Open.Image = (Image)resources.GetObject("toolStripMenuItem_Open.Image");
            toolStripMenuItem_Open.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem_Open.Name = "toolStripMenuItem_Open";
            toolStripMenuItem_Open.Size = new Size(177, 22);
            toolStripMenuItem_Open.Text = "開く(&O)";
            // 
            // toolStripSeparator_FileMenu
            // 
            toolStripSeparator_FileMenu.Name = "toolStripSeparator_FileMenu";
            toolStripSeparator_FileMenu.Size = new Size(174, 6);
            // 
            // toolStripMenuItem_Save
            // 
            toolStripMenuItem_Save.Image = (Image)resources.GetObject("toolStripMenuItem_Save.Image");
            toolStripMenuItem_Save.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem_Save.Name = "toolStripMenuItem_Save";
            toolStripMenuItem_Save.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItem_Save.Size = new Size(177, 22);
            toolStripMenuItem_Save.Text = "保存(&S)";
            // 
            // toolStripMenuItem_SaveAs
            // 
            toolStripMenuItem_SaveAs.Name = "toolStripMenuItem_SaveAs";
            toolStripMenuItem_SaveAs.Size = new Size(177, 22);
            toolStripMenuItem_SaveAs.Text = "名前を付けて保存(&A)";
            // 
            // toolStripSeparator_SaveMenu
            // 
            toolStripSeparator_SaveMenu.Name = "toolStripSeparator_SaveMenu";
            toolStripSeparator_SaveMenu.Size = new Size(174, 6);
            // 
            // toolStripMenuItem_Print
            // 
            toolStripMenuItem_Print.Image = (Image)resources.GetObject("toolStripMenuItem_Print.Image");
            toolStripMenuItem_Print.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem_Print.Name = "toolStripMenuItem_Print";
            toolStripMenuItem_Print.ShortcutKeys = Keys.Control | Keys.P;
            toolStripMenuItem_Print.Size = new Size(177, 22);
            toolStripMenuItem_Print.Text = "印刷(&P)";
            // 
            // toolStripMenuItem_PrintPreview
            // 
            toolStripMenuItem_PrintPreview.Image = (Image)resources.GetObject("toolStripMenuItem_PrintPreview.Image");
            toolStripMenuItem_PrintPreview.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem_PrintPreview.Name = "toolStripMenuItem_PrintPreview";
            toolStripMenuItem_PrintPreview.Size = new Size(177, 22);
            toolStripMenuItem_PrintPreview.Text = "印刷プレビュー(&V)";
            // 
            // toolStripSeparator_PrintMenu
            // 
            toolStripSeparator_PrintMenu.Name = "toolStripSeparator_PrintMenu";
            toolStripSeparator_PrintMenu.Size = new Size(174, 6);
            // 
            // toolStripMenuItem_Exit
            // 
            toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            toolStripMenuItem_Exit.Size = new Size(177, 22);
            toolStripMenuItem_Exit.Text = "終了(&X)";
            // 
            // toolStripMenuItem_Edit
            // 
            toolStripMenuItem_Edit.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_Undo, toolStripMenuItem_Redo, toolStripSeparator_UndoMenu, toolStripMenuItem_Cut, toolStripMenuItem_Copy, toolStripMenuItem_Paste, toolStripSeparator_CAPMenu, toolStripMenuItem_SelectAll });
            toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
            toolStripMenuItem_Edit.Size = new Size(57, 20);
            toolStripMenuItem_Edit.Text = "編集(&E)";
            // 
            // toolStripMenuItem_Undo
            // 
            toolStripMenuItem_Undo.Name = "toolStripMenuItem_Undo";
            toolStripMenuItem_Undo.Size = new Size(143, 22);
            toolStripMenuItem_Undo.Text = "元に戻す(&U)";
            // 
            // toolStripMenuItem_Redo
            // 
            toolStripMenuItem_Redo.Name = "toolStripMenuItem_Redo";
            toolStripMenuItem_Redo.Size = new Size(143, 22);
            toolStripMenuItem_Redo.Text = "やり直し(&R)";
            // 
            // toolStripSeparator_UndoMenu
            // 
            toolStripSeparator_UndoMenu.Name = "toolStripSeparator_UndoMenu";
            toolStripSeparator_UndoMenu.Size = new Size(140, 6);
            // 
            // toolStripMenuItem_Cut
            // 
            toolStripMenuItem_Cut.Image = (Image)resources.GetObject("toolStripMenuItem_Cut.Image");
            toolStripMenuItem_Cut.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem_Cut.Name = "toolStripMenuItem_Cut";
            toolStripMenuItem_Cut.Size = new Size(143, 22);
            toolStripMenuItem_Cut.Text = "切り取り(&T)";
            // 
            // toolStripMenuItem_Copy
            // 
            toolStripMenuItem_Copy.Image = (Image)resources.GetObject("toolStripMenuItem_Copy.Image");
            toolStripMenuItem_Copy.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem_Copy.Name = "toolStripMenuItem_Copy";
            toolStripMenuItem_Copy.Size = new Size(143, 22);
            toolStripMenuItem_Copy.Text = "コピー(&C)";
            // 
            // toolStripMenuItem_Paste
            // 
            toolStripMenuItem_Paste.Image = (Image)resources.GetObject("toolStripMenuItem_Paste.Image");
            toolStripMenuItem_Paste.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem_Paste.Name = "toolStripMenuItem_Paste";
            toolStripMenuItem_Paste.Size = new Size(143, 22);
            toolStripMenuItem_Paste.Text = "貼り付け(&P)";
            // 
            // toolStripSeparator_CAPMenu
            // 
            toolStripSeparator_CAPMenu.Name = "toolStripSeparator_CAPMenu";
            toolStripSeparator_CAPMenu.Size = new Size(140, 6);
            // 
            // toolStripMenuItem_SelectAll
            // 
            toolStripMenuItem_SelectAll.Name = "toolStripMenuItem_SelectAll";
            toolStripMenuItem_SelectAll.Size = new Size(143, 22);
            toolStripMenuItem_SelectAll.Text = "すべて選択(&A)";
            // 
            // toolStripMenuItem_Tool
            // 
            toolStripMenuItem_Tool.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_Customize, toolStripMenuItem_Option });
            toolStripMenuItem_Tool.Name = "toolStripMenuItem_Tool";
            toolStripMenuItem_Tool.Size = new Size(60, 20);
            toolStripMenuItem_Tool.Text = "ツール(&T)";
            // 
            // toolStripMenuItem_Customize
            // 
            toolStripMenuItem_Customize.Name = "toolStripMenuItem_Customize";
            toolStripMenuItem_Customize.Size = new Size(143, 22);
            toolStripMenuItem_Customize.Text = "カスタマイズ(&C)";
            // 
            // toolStripMenuItem_Option
            // 
            toolStripMenuItem_Option.Name = "toolStripMenuItem_Option";
            toolStripMenuItem_Option.Size = new Size(143, 22);
            toolStripMenuItem_Option.Text = "オプション(&O)";
            // 
            // toolStripMenuItem_Help
            // 
            toolStripMenuItem_Help.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_OpenHelp, toolStripSeparator_HelpMenu, toolStripMenuItem_About });
            toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            toolStripMenuItem_Help.Size = new Size(65, 20);
            toolStripMenuItem_Help.Text = "ヘルプ(&H)";
            // 
            // toolStripMenuItem_OpenHelp
            // 
            toolStripMenuItem_OpenHelp.Name = "toolStripMenuItem_OpenHelp";
            toolStripMenuItem_OpenHelp.Size = new Size(167, 22);
            toolStripMenuItem_OpenHelp.Text = "ヘルプを開く";
            // 
            // toolStripSeparator_HelpMenu
            // 
            toolStripSeparator_HelpMenu.Name = "toolStripSeparator_HelpMenu";
            toolStripSeparator_HelpMenu.Size = new Size(164, 6);
            // 
            // toolStripMenuItem_About
            // 
            toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            toolStripMenuItem_About.Size = new Size(167, 22);
            toolStripMenuItem_About.Text = "バージョン情報(&A)...";
            // 
            // picMain
            // 
            picMain.Dock = DockStyle.Fill;
            picMain.Location = new Point(0, 49);
            picMain.Name = "picMain";
            picMain.Size = new Size(1207, 658);
            picMain.TabIndex = 18;
            picMain.TabStop = false;
            picMain.Paint += picMain_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1207, 729);
            Controls.Add(picMain);
            Controls.Add(tableLayoutPanelTop);
            Controls.Add(statusStrip);
            Name = "Main";
            Text = "AILDOTEDT";
            tableLayoutPanelTop.ResumeLayout(false);
            tableLayoutPanelTop.PerformLayout();
            toolStripCommand.ResumeLayout(false);
            toolStripCommand.PerformLayout();
            toolStripContent.ResumeLayout(false);
            toolStripContent.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip;
        private TableLayoutPanel tableLayoutPanelTop;
        private ToolStrip toolStripContent;
        private ToolStripButton toolStripButton1;
        private MenuStrip menuStrip;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripLabel1;
        private PictureBox picMain;
        private ToolStrip toolStripCommand;
        private ToolStripButton toolStripButton_New;
        private ToolStripButton toolStripButton_Open;
        private ToolStripButton toolStripButton_Save;
        private ToolStripButton toolStripButton_Print;
        private ToolStripSeparator toolStripSeparator_File;
        private ToolStripButton toolStripButton_Cut;
        private ToolStripButton toolStripButton_Copy;
        private ToolStripButton toolStripButton_Paste;
        private ToolStripSeparator toolStripSeparator_Edit;
        private ToolStripButton toolStripButton_Help;
        private ToolStripMenuItem toolStripMenuItem_File;
        private ToolStripMenuItem toolStripMenuItem_New;
        private ToolStripMenuItem toolStripMenuItem_Open;
        private ToolStripSeparator toolStripSeparator_FileMenu;
        private ToolStripMenuItem toolStripMenuItem_Save;
        private ToolStripMenuItem toolStripMenuItem_SaveAs;
        private ToolStripSeparator toolStripSeparator_SaveMenu;
        private ToolStripMenuItem toolStripMenuItem_Print;
        private ToolStripMenuItem toolStripMenuItem_PrintPreview;
        private ToolStripSeparator toolStripSeparator_PrintMenu;
        private ToolStripMenuItem toolStripMenuItem_Exit;
        private ToolStripMenuItem toolStripMenuItem_Edit;
        private ToolStripMenuItem toolStripMenuItem_Undo;
        private ToolStripMenuItem toolStripMenuItem_Redo;
        private ToolStripSeparator toolStripSeparator_UndoMenu;
        private ToolStripMenuItem toolStripMenuItem_Cut;
        private ToolStripMenuItem toolStripMenuItem_Copy;
        private ToolStripMenuItem toolStripMenuItem_Paste;
        private ToolStripSeparator toolStripSeparator_CAPMenu;
        private ToolStripMenuItem toolStripMenuItem_SelectAll;
        private ToolStripMenuItem toolStripMenuItem_Tool;
        private ToolStripMenuItem toolStripMenuItem_Customize;
        private ToolStripMenuItem toolStripMenuItem_Option;
        private ToolStripMenuItem toolStripMenuItem_Help;
        private ToolStripMenuItem toolStripMenuItem_OpenHelp;
        private ToolStripSeparator toolStripSeparator_HelpMenu;
        private ToolStripMenuItem toolStripMenuItem_About;
    }
}