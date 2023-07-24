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
            nudScreenWidth = new NumericUpDown();
            groupBox1 = new GroupBox();
            label2 = new Label();
            nudScreenHeight = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            nudColorCount = new NumericUpDown();
            groupBox2 = new GroupBox();
            label5 = new Label();
            nudCharacterHeight = new NumericUpDown();
            label6 = new Label();
            nudCharacterWidth = new NumericUpDown();
            groupBox3 = new GroupBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            label7 = new Label();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudScreenWidth).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudScreenHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColorCount).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCharacterHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCharacterWidth).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nudScreenWidth
            // 
            nudScreenWidth.Location = new Point(86, 28);
            nudScreenWidth.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            nudScreenWidth.Name = "nudScreenWidth";
            nudScreenWidth.Size = new Size(92, 23);
            nudScreenWidth.TabIndex = 0;
            nudScreenWidth.TextAlign = HorizontalAlignment.Right;
            nudScreenWidth.Value = new decimal(new int[] { 800, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nudScreenHeight);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nudScreenWidth);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 71);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "画面";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 30);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "高さ";
            // 
            // nudScreenHeight
            // 
            nudScreenHeight.Location = new Point(241, 28);
            nudScreenHeight.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            nudScreenHeight.Name = "nudScreenHeight";
            nudScreenHeight.Size = new Size(92, 23);
            nudScreenHeight.TabIndex = 2;
            nudScreenHeight.TextAlign = HorizontalAlignment.Right;
            nudScreenHeight.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 30);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 1;
            label1.Text = "幅";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 21);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "色数";
            // 
            // nudColorCount
            // 
            nudColorCount.Location = new Point(86, 19);
            nudColorCount.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            nudColorCount.Name = "nudColorCount";
            nudColorCount.Size = new Size(92, 23);
            nudColorCount.TabIndex = 4;
            nudColorCount.TextAlign = HorizontalAlignment.Right;
            nudColorCount.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(nudCharacterHeight);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(nudCharacterWidth);
            groupBox2.Location = new Point(12, 159);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 79);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "キャラサイズ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 30);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 3;
            label5.Text = "高さ";
            // 
            // nudCharacterHeight
            // 
            nudCharacterHeight.Location = new Point(241, 28);
            nudCharacterHeight.Name = "nudCharacterHeight";
            nudCharacterHeight.Size = new Size(92, 23);
            nudCharacterHeight.TabIndex = 2;
            nudCharacterHeight.TextAlign = HorizontalAlignment.Right;
            nudCharacterHeight.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 30);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 1;
            label6.Text = "幅";
            // 
            // nudCharacterWidth
            // 
            nudCharacterWidth.Location = new Point(86, 28);
            nudCharacterWidth.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            nudCharacterWidth.Name = "nudCharacterWidth";
            nudCharacterWidth.Size = new Size(92, 23);
            nudCharacterWidth.TabIndex = 0;
            nudCharacterWidth.TextAlign = HorizontalAlignment.Right;
            nudCharacterWidth.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(nudColorCount);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Location = new Point(12, 244);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(460, 159);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "パレット";
            // 
            // button1
            // 
            button1.Location = new Point(379, 17);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "編集";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(86, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 56);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "ターゲット";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 9;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(253, 412);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(107, 31);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(366, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "キャンセル(&C)";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 20);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "名前";
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(374, 23);
            txtName.TabIndex = 13;
            // 
            // DlgNewProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 453);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DlgNewProject";
            StartPosition = FormStartPosition.CenterParent;
            Text = "新規作成";
            Load += DlgNewProject_Load;
            ((System.ComponentModel.ISupportInitialize)nudScreenWidth).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudScreenHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColorCount).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCharacterHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCharacterWidth).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label7;
        private TextBox txtName;
    }
}