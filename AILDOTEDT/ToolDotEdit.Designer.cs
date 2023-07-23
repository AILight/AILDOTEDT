namespace AILDOTEDT
{
    partial class ToolDotEdit
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
            cboZoom = new ComboBox();
            picDotEdit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picDotEdit).BeginInit();
            SuspendLayout();
            // 
            // cboZoom
            // 
            cboZoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZoom.FormattingEnabled = true;
            cboZoom.Items.AddRange(new object[] { "x1", "x2", "x4", "x8", "x16" });
            cboZoom.Location = new Point(3, 4);
            cboZoom.Name = "cboZoom";
            cboZoom.Size = new Size(120, 23);
            cboZoom.TabIndex = 5;
            // 
            // picDotEdit
            // 
            picDotEdit.BackColor = SystemColors.ControlDark;
            picDotEdit.Location = new Point(3, 33);
            picDotEdit.Name = "picDotEdit";
            picDotEdit.Size = new Size(406, 313);
            picDotEdit.TabIndex = 4;
            picDotEdit.TabStop = false;
            // 
            // ToolDotEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 346);
            Controls.Add(cboZoom);
            Controls.Add(picDotEdit);
            Name = "ToolDotEdit";
            ShowIcon = false;
            Text = "ToolDotEdit";
            ((System.ComponentModel.ISupportInitialize)picDotEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboZoom;
        private PictureBox picDotEdit;
    }
}