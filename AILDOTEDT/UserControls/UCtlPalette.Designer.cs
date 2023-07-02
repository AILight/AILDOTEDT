namespace AILDOTEDT.UserControls
{
    partial class UCtlPalette
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.picPalette = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPalette)).BeginInit();
            this.SuspendLayout();
            // 
            // picPalette
            // 
            this.picPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPalette.Location = new System.Drawing.Point(0, 0);
            this.picPalette.Name = "picPalette";
            this.picPalette.Size = new System.Drawing.Size(399, 150);
            this.picPalette.TabIndex = 0;
            this.picPalette.TabStop = false;
            this.picPalette.Paint += new System.Windows.Forms.PaintEventHandler(this.picPalette_Paint);
            // 
            // UCtlPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPalette);
            this.Name = "UCtlPalette";
            this.Size = new System.Drawing.Size(399, 150);
            this.Load += new System.EventHandler(this.UCtlPalette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPalette)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picPalette;
    }
}
