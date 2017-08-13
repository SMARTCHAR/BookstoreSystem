namespace Library
{
    partial class InputForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Diglabel3 = new System.Windows.Forms.Label();
            this.Diglabel2 = new System.Windows.Forms.Label();
            this.Diglabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.leftBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.publisherBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(100, 66);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(188, 26);
            this.nameBox.TabIndex = 1;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(100, 94);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(188, 26);
            this.authorBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "书名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "作者";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Diglabel3);
            this.groupBox1.Controls.Add(this.Diglabel2);
            this.groupBox1.Controls.Add(this.Diglabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.leftBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.publisherBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.codeBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.authorBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(213, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 345);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加图书条目";
            // 
            // Diglabel3
            // 
            this.Diglabel3.AutoSize = true;
            this.Diglabel3.ForeColor = System.Drawing.Color.Red;
            this.Diglabel3.Location = new System.Drawing.Point(294, 126);
            this.Diglabel3.Name = "Diglabel3";
            this.Diglabel3.Size = new System.Drawing.Size(89, 20);
            this.Diglabel3.TabIndex = 18;
            this.Diglabel3.Text = "* 请输入数字";
            this.Diglabel3.Visible = false;
            // 
            // Diglabel2
            // 
            this.Diglabel2.AutoSize = true;
            this.Diglabel2.ForeColor = System.Drawing.Color.Red;
            this.Diglabel2.Location = new System.Drawing.Point(294, 212);
            this.Diglabel2.Name = "Diglabel2";
            this.Diglabel2.Size = new System.Drawing.Size(89, 20);
            this.Diglabel2.TabIndex = 17;
            this.Diglabel2.Text = "* 请输入数字";
            this.Diglabel2.Visible = false;
            // 
            // Diglabel
            // 
            this.Diglabel.AutoSize = true;
            this.Diglabel.ForeColor = System.Drawing.Color.Red;
            this.Diglabel.Location = new System.Drawing.Point(294, 180);
            this.Diglabel.Name = "Diglabel";
            this.Diglabel.Size = new System.Drawing.Size(89, 20);
            this.Diglabel.TabIndex = 16;
            this.Diglabel.Text = "* 请输入数字";
            this.Diglabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "定价";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(100, 178);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(188, 26);
            this.priceBox.TabIndex = 5;
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "分类";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "G 文化、科学、教育、体育",
            "H 语言、文字",
            "O 数理科学和化学",
            "T 工业技术",
            "V 航空、航天"});
            this.comboBox1.Location = new System.Drawing.Point(100, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "数量";
            // 
            // leftBox
            // 
            this.leftBox.Location = new System.Drawing.Point(100, 207);
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(188, 26);
            this.leftBox.TabIndex = 6;
            this.leftBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leftBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "出版社";
            // 
            // publisherBox
            // 
            this.publisherBox.Location = new System.Drawing.Point(100, 150);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(188, 26);
            this.publisherBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "条形码";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(100, 122);
            this.codeBox.MaxLength = 8;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(188, 26);
            this.codeBox.TabIndex = 3;
            this.codeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeBox_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputForm";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox leftBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox publisherBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label Diglabel;
        private System.Windows.Forms.Label Diglabel2;
        private System.Windows.Forms.Label Diglabel3;
    }
}