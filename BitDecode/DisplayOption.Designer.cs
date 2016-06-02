namespace BitDecode
{
    partial class DisplayOption
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radio_custom_2 = new System.Windows.Forms.RadioButton();
            this.radio_douhao_space_2 = new System.Windows.Forms.RadioButton();
            this.radio_maohao_2 = new System.Windows.Forms.RadioButton();
            this.radio_fenhao_2 = new System.Windows.Forms.RadioButton();
            this.radio_space_2 = new System.Windows.Forms.RadioButton();
            this.radio_douhao_2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radio_custom_16 = new System.Windows.Forms.RadioButton();
            this.radio_douhao_space_16 = new System.Windows.Forms.RadioButton();
            this.radio_maohao_16 = new System.Windows.Forms.RadioButton();
            this.radio_fenhao_16 = new System.Windows.Forms.RadioButton();
            this.radio_space_16 = new System.Windows.Forms.RadioButton();
            this.radio_douhao_16 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "二进制";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormatString = "N0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.comboBox1.Location = new System.Drawing.Point(76, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "分割位数";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.radio_custom_2);
            this.groupBox4.Controls.Add(this.radio_douhao_space_2);
            this.groupBox4.Controls.Add(this.radio_maohao_2);
            this.groupBox4.Controls.Add(this.radio_fenhao_2);
            this.groupBox4.Controls.Add(this.radio_space_2);
            this.groupBox4.Controls.Add(this.radio_douhao_2);
            this.groupBox4.Location = new System.Drawing.Point(19, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 97);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "分隔符";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // radio_custom_2
            // 
            this.radio_custom_2.AutoSize = true;
            this.radio_custom_2.Location = new System.Drawing.Point(23, 65);
            this.radio_custom_2.Name = "radio_custom_2";
            this.radio_custom_2.Size = new System.Drawing.Size(59, 16);
            this.radio_custom_2.TabIndex = 0;
            this.radio_custom_2.TabStop = true;
            this.radio_custom_2.Text = "自定义";
            this.radio_custom_2.UseVisualStyleBackColor = true;
            // 
            // radio_douhao_space_2
            // 
            this.radio_douhao_space_2.AutoSize = true;
            this.radio_douhao_space_2.Location = new System.Drawing.Point(76, 43);
            this.radio_douhao_space_2.Name = "radio_douhao_space_2";
            this.radio_douhao_space_2.Size = new System.Drawing.Size(77, 16);
            this.radio_douhao_space_2.TabIndex = 0;
            this.radio_douhao_space_2.TabStop = true;
            this.radio_douhao_space_2.Text = "逗号+空格";
            this.radio_douhao_space_2.UseVisualStyleBackColor = true;
            // 
            // radio_maohao_2
            // 
            this.radio_maohao_2.AutoSize = true;
            this.radio_maohao_2.Location = new System.Drawing.Point(23, 43);
            this.radio_maohao_2.Name = "radio_maohao_2";
            this.radio_maohao_2.Size = new System.Drawing.Size(47, 16);
            this.radio_maohao_2.TabIndex = 0;
            this.radio_maohao_2.TabStop = true;
            this.radio_maohao_2.Text = "冒号";
            this.radio_maohao_2.UseVisualStyleBackColor = true;
            // 
            // radio_fenhao_2
            // 
            this.radio_fenhao_2.AutoSize = true;
            this.radio_fenhao_2.Location = new System.Drawing.Point(129, 21);
            this.radio_fenhao_2.Name = "radio_fenhao_2";
            this.radio_fenhao_2.Size = new System.Drawing.Size(47, 16);
            this.radio_fenhao_2.TabIndex = 0;
            this.radio_fenhao_2.TabStop = true;
            this.radio_fenhao_2.Text = "分号";
            this.radio_fenhao_2.UseVisualStyleBackColor = true;
            // 
            // radio_space_2
            // 
            this.radio_space_2.AutoSize = true;
            this.radio_space_2.Location = new System.Drawing.Point(76, 21);
            this.radio_space_2.Name = "radio_space_2";
            this.radio_space_2.Size = new System.Drawing.Size(47, 16);
            this.radio_space_2.TabIndex = 0;
            this.radio_space_2.TabStop = true;
            this.radio_space_2.Text = "空格";
            this.radio_space_2.UseVisualStyleBackColor = true;
            // 
            // radio_douhao_2
            // 
            this.radio_douhao_2.AutoSize = true;
            this.radio_douhao_2.Location = new System.Drawing.Point(23, 21);
            this.radio_douhao_2.Name = "radio_douhao_2";
            this.radio_douhao_2.Size = new System.Drawing.Size(47, 16);
            this.radio_douhao_2.TabIndex = 0;
            this.radio_douhao_2.TabStop = true;
            this.radio_douhao_2.Text = "逗号";
            this.radio_douhao_2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(253, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "十六进制";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.comboBox2.Location = new System.Drawing.Point(76, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "分割位数";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.radio_custom_16);
            this.groupBox3.Controls.Add(this.radio_douhao_space_16);
            this.groupBox3.Controls.Add(this.radio_maohao_16);
            this.groupBox3.Controls.Add(this.radio_fenhao_16);
            this.groupBox3.Controls.Add(this.radio_space_16);
            this.groupBox3.Controls.Add(this.radio_douhao_16);
            this.groupBox3.Location = new System.Drawing.Point(19, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 97);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "分隔符";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            // 
            // radio_custom_16
            // 
            this.radio_custom_16.AutoSize = true;
            this.radio_custom_16.Location = new System.Drawing.Point(23, 65);
            this.radio_custom_16.Name = "radio_custom_16";
            this.radio_custom_16.Size = new System.Drawing.Size(59, 16);
            this.radio_custom_16.TabIndex = 0;
            this.radio_custom_16.TabStop = true;
            this.radio_custom_16.Text = "自定义";
            this.radio_custom_16.UseVisualStyleBackColor = true;
            // 
            // radio_douhao_space_16
            // 
            this.radio_douhao_space_16.AutoSize = true;
            this.radio_douhao_space_16.Location = new System.Drawing.Point(76, 43);
            this.radio_douhao_space_16.Name = "radio_douhao_space_16";
            this.radio_douhao_space_16.Size = new System.Drawing.Size(77, 16);
            this.radio_douhao_space_16.TabIndex = 0;
            this.radio_douhao_space_16.TabStop = true;
            this.radio_douhao_space_16.Text = "逗号+空格";
            this.radio_douhao_space_16.UseVisualStyleBackColor = true;
            // 
            // radio_maohao_16
            // 
            this.radio_maohao_16.AutoSize = true;
            this.radio_maohao_16.Location = new System.Drawing.Point(23, 43);
            this.radio_maohao_16.Name = "radio_maohao_16";
            this.radio_maohao_16.Size = new System.Drawing.Size(47, 16);
            this.radio_maohao_16.TabIndex = 0;
            this.radio_maohao_16.TabStop = true;
            this.radio_maohao_16.Text = "冒号";
            this.radio_maohao_16.UseVisualStyleBackColor = true;
            // 
            // radio_fenhao_16
            // 
            this.radio_fenhao_16.AutoSize = true;
            this.radio_fenhao_16.Location = new System.Drawing.Point(129, 21);
            this.radio_fenhao_16.Name = "radio_fenhao_16";
            this.radio_fenhao_16.Size = new System.Drawing.Size(47, 16);
            this.radio_fenhao_16.TabIndex = 0;
            this.radio_fenhao_16.TabStop = true;
            this.radio_fenhao_16.Text = "分号";
            this.radio_fenhao_16.UseVisualStyleBackColor = true;
            // 
            // radio_space_16
            // 
            this.radio_space_16.AutoSize = true;
            this.radio_space_16.Location = new System.Drawing.Point(76, 21);
            this.radio_space_16.Name = "radio_space_16";
            this.radio_space_16.Size = new System.Drawing.Size(47, 16);
            this.radio_space_16.TabIndex = 0;
            this.radio_space_16.TabStop = true;
            this.radio_space_16.Text = "空格";
            this.radio_space_16.UseVisualStyleBackColor = true;
            // 
            // radio_douhao_16
            // 
            this.radio_douhao_16.AutoSize = true;
            this.radio_douhao_16.Location = new System.Drawing.Point(23, 21);
            this.radio_douhao_16.Name = "radio_douhao_16";
            this.radio_douhao_16.Size = new System.Drawing.Size(47, 16);
            this.radio_douhao_16.TabIndex = 0;
            this.radio_douhao_16.TabStop = true;
            this.radio_douhao_16.Text = "逗号";
            this.radio_douhao_16.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(403, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DisplayOption
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(495, 244);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "显示设置";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radio_custom_2;
        private System.Windows.Forms.RadioButton radio_douhao_space_2;
        private System.Windows.Forms.RadioButton radio_maohao_2;
        private System.Windows.Forms.RadioButton radio_fenhao_2;
        private System.Windows.Forms.RadioButton radio_space_2;
        private System.Windows.Forms.RadioButton radio_douhao_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radio_custom_16;
        private System.Windows.Forms.RadioButton radio_douhao_space_16;
        private System.Windows.Forms.RadioButton radio_maohao_16;
        private System.Windows.Forms.RadioButton radio_fenhao_16;
        private System.Windows.Forms.RadioButton radio_space_16;
        private System.Windows.Forms.RadioButton radio_douhao_16;
    }
}