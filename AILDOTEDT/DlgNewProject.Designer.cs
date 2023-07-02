namespace AILDOTEDT
{
    partial class DlgNewProject
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
            this.nudScreenWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudScreenHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudColorCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCharacterHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCharacterWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterWidth)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudScreenWidth
            // 
            this.nudScreenWidth.Location = new System.Drawing.Point(86, 28);
            this.nudScreenWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.nudScreenWidth.Name = "nudScreenWidth";
            this.nudScreenWidth.Size = new System.Drawing.Size(92, 23);
            this.nudScreenWidth.TabIndex = 0;
            this.nudScreenWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudScreenWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudScreenHeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudScreenWidth);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "画面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "高さ";
            // 
            // nudScreenHeight
            // 
            this.nudScreenHeight.Location = new System.Drawing.Point(241, 28);
            this.nudScreenHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.nudScreenHeight.Name = "nudScreenHeight";
            this.nudScreenHeight.Size = new System.Drawing.Size(92, 23);
            this.nudScreenHeight.TabIndex = 2;
            this.nudScreenHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudScreenHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "幅";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "色数";
            // 
            // nudColorCount
            // 
            this.nudColorCount.Location = new System.Drawing.Point(86, 19);
            this.nudColorCount.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudColorCount.Name = "nudColorCount";
            this.nudColorCount.Size = new System.Drawing.Size(92, 23);
            this.nudColorCount.TabIndex = 4;
            this.nudColorCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudColorCount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudCharacterHeight);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudCharacterWidth);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "キャラサイズ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "高さ";
            // 
            // nudCharacterHeight
            // 
            this.nudCharacterHeight.Location = new System.Drawing.Point(241, 28);
            this.nudCharacterHeight.Name = "nudCharacterHeight";
            this.nudCharacterHeight.Size = new System.Drawing.Size(92, 23);
            this.nudCharacterHeight.TabIndex = 2;
            this.nudCharacterHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCharacterHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "幅";
            // 
            // nudCharacterWidth
            // 
            this.nudCharacterWidth.Location = new System.Drawing.Point(86, 28);
            this.nudCharacterWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.nudCharacterWidth.Name = "nudCharacterWidth";
            this.nudCharacterWidth.Size = new System.Drawing.Size(92, 23);
            this.nudCharacterWidth.TabIndex = 0;
            this.nudCharacterWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCharacterWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.nudColorCount);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 159);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "パレット";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "編集";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(86, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ターゲット";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(253, 370);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 31);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(366, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "キャンセル(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DlgNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 413);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DlgNewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新規作成";
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterWidth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudScreenWidth;
        private GroupBox groupBox1;
        private Label label3;
        private NumericUpDown nudColorCount;
        private Label label2;
        private NumericUpDown nudScreenHeight;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private NumericUpDown nudCharacterHeight;
        private Label label6;
        private NumericUpDown nudCharacterWidth;
        private GroupBox groupBox3;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Button btnOK;
        private Button btnCancel;
    }
}