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
            this.cboZoom = new System.Windows.Forms.ComboBox();
            this.picDotEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDotEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // cboZoom
            // 
            this.cboZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZoom.FormattingEnabled = true;
            this.cboZoom.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.cboZoom.Location = new System.Drawing.Point(3, 4);
            this.cboZoom.Name = "cboZoom";
            this.cboZoom.Size = new System.Drawing.Size(120, 23);
            this.cboZoom.TabIndex = 5;
            // 
            // picDotEdit
            // 
            this.picDotEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picDotEdit.Location = new System.Drawing.Point(3, 33);
            this.picDotEdit.Name = "picDotEdit";
            this.picDotEdit.Size = new System.Drawing.Size(406, 313);
            this.picDotEdit.TabIndex = 4;
            this.picDotEdit.TabStop = false;
            // 
            // ToolDotEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 346);
            this.Controls.Add(this.cboZoom);
            this.Controls.Add(this.picDotEdit);
            this.Name = "ToolDotEdit";
            this.ShowIcon = false;
            this.Text = "ToolDotEdit";
            ((System.ComponentModel.ISupportInitialize)(this.picDotEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cboZoom;
        private PictureBox picDotEdit;
    }
}