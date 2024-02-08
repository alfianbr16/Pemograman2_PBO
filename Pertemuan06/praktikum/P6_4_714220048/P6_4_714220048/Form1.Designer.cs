namespace P6_4_714220048
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb11 = new System.Windows.Forms.RadioButton();
            this.rb17 = new System.Windows.Forms.RadioButton();
            this.rb25 = new System.Windows.Forms.RadioButton();
            this.rb40 = new System.Windows.Forms.RadioButton();
            this.rb53 = new System.Windows.Forms.RadioButton();
            this.rb77 = new System.Windows.Forms.RadioButton();
            this.rbDana = new System.Windows.Forms.RadioButton();
            this.rbGopay = new System.Windows.Forms.RadioButton();
            this.rbOvo = new System.Windows.Forms.RadioButton();
            this.rbSpaylater = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Depan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(212, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(212, 101);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 4;
            this.tbId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbId.Leave += new System.EventHandler(this.tbId_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb77);
            this.groupBox1.Controls.Add(this.rb53);
            this.groupBox1.Controls.Add(this.rb40);
            this.groupBox1.Controls.Add(this.rb25);
            this.groupBox1.Controls.Add(this.rb17);
            this.groupBox1.Controls.Add(this.rb11);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Location = new System.Drawing.Point(51, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Item";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSpaylater);
            this.groupBox2.Controls.Add(this.rbOvo);
            this.groupBox2.Controls.Add(this.rbGopay);
            this.groupBox2.Controls.Add(this.rbDana);
            this.groupBox2.Location = new System.Drawing.Point(423, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 165);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembayaran";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(6, 19);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(87, 30);
            this.rb3.TabIndex = 0;
            this.rb3.TabStop = true;
            this.rb3.Text = "3 Diamonds  \r\nRp.1.300";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(6, 49);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(144, 30);
            this.rb5.TabIndex = 1;
            this.rb5.TabStop = true;
            this.rb5.Text = "5 Diamonds                     \r\nRp.1.579 ";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb11
            // 
            this.rb11.AutoSize = true;
            this.rb11.Location = new System.Drawing.Point(6, 79);
            this.rb11.Name = "rb11";
            this.rb11.Size = new System.Drawing.Size(138, 30);
            this.rb11.TabIndex = 2;
            this.rb11.TabStop = true;
            this.rb11.Text = "11 Diamonds + 1 Bonus\r\nRp.3.688";
            this.rb11.UseVisualStyleBackColor = true;
            // 
            // rb17
            // 
            this.rb17.AutoSize = true;
            this.rb17.Location = new System.Drawing.Point(6, 115);
            this.rb17.Name = "rb17";
            this.rb17.Size = new System.Drawing.Size(138, 30);
            this.rb17.TabIndex = 3;
            this.rb17.TabStop = true;
            this.rb17.Text = "17 Diamonds + 2 Bonus\r\nRp.5.797";
            this.rb17.UseVisualStyleBackColor = true;
            // 
            // rb25
            // 
            this.rb25.AutoSize = true;
            this.rb25.Location = new System.Drawing.Point(173, 19);
            this.rb25.Name = "rb25";
            this.rb25.Size = new System.Drawing.Size(138, 30);
            this.rb25.TabIndex = 4;
            this.rb25.TabStop = true;
            this.rb25.Text = "25 Diamonds + 3 Bonus\r\nRp.8.346";
            this.rb25.UseVisualStyleBackColor = true;
            // 
            // rb40
            // 
            this.rb40.AutoSize = true;
            this.rb40.Location = new System.Drawing.Point(173, 49);
            this.rb40.Name = "rb40";
            this.rb40.Size = new System.Drawing.Size(138, 30);
            this.rb40.TabIndex = 5;
            this.rb40.TabStop = true;
            this.rb40.Text = "40 Diamonds + 4 Bonus\r\nRp.12.654";
            this.rb40.UseVisualStyleBackColor = true;
            // 
            // rb53
            // 
            this.rb53.AutoSize = true;
            this.rb53.Location = new System.Drawing.Point(173, 79);
            this.rb53.Name = "rb53";
            this.rb53.Size = new System.Drawing.Size(138, 30);
            this.rb53.TabIndex = 6;
            this.rb53.TabStop = true;
            this.rb53.Text = "53 Diamonds + 6 Bonus\r\nRp.16.872";
            this.rb53.UseVisualStyleBackColor = true;
            // 
            // rb77
            // 
            this.rb77.AutoSize = true;
            this.rb77.Location = new System.Drawing.Point(173, 115);
            this.rb77.Name = "rb77";
            this.rb77.Size = new System.Drawing.Size(138, 30);
            this.rb77.TabIndex = 7;
            this.rb77.TabStop = true;
            this.rb77.Text = "77 Diamonds + 8 Bonus\r\nRp.24.254";
            this.rb77.UseVisualStyleBackColor = true;
            // 
            // rbDana
            // 
            this.rbDana.AutoSize = true;
            this.rbDana.Location = new System.Drawing.Point(7, 20);
            this.rbDana.Name = "rbDana";
            this.rbDana.Size = new System.Drawing.Size(55, 17);
            this.rbDana.TabIndex = 0;
            this.rbDana.TabStop = true;
            this.rbDana.Text = "DANA";
            this.rbDana.UseVisualStyleBackColor = true;
            // 
            // rbGopay
            // 
            this.rbGopay.AutoSize = true;
            this.rbGopay.Location = new System.Drawing.Point(7, 56);
            this.rbGopay.Name = "rbGopay";
            this.rbGopay.Size = new System.Drawing.Size(65, 17);
            this.rbGopay.TabIndex = 1;
            this.rbGopay.TabStop = true;
            this.rbGopay.Text = "GO-PAY";
            this.rbGopay.UseVisualStyleBackColor = true;
            // 
            // rbOvo
            // 
            this.rbOvo.AutoSize = true;
            this.rbOvo.Location = new System.Drawing.Point(6, 92);
            this.rbOvo.Name = "rbOvo";
            this.rbOvo.Size = new System.Drawing.Size(48, 17);
            this.rbOvo.TabIndex = 2;
            this.rbOvo.TabStop = true;
            this.rbOvo.Text = "OVO";
            this.rbOvo.UseVisualStyleBackColor = true;
            // 
            // rbSpaylater
            // 
            this.rbSpaylater.AutoSize = true;
            this.rbSpaylater.Location = new System.Drawing.Point(6, 128);
            this.rbSpaylater.Name = "rbSpaylater";
            this.rbSpaylater.Size = new System.Drawing.Size(74, 17);
            this.rbSpaylater.TabIndex = 3;
            this.rbSpaylater.TabStop = true;
            this.rbSpaylater.Text = "SPayLater";
            this.rbSpaylater.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(304, 365);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 8;
            this.btnTampilkan.Text = "Tapilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(423, 365);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(62, 23);
            this.btnSelesai.TabIndex = 9;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alamat E- mail";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(212, 137);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(100, 20);
            this.tbMail.TabIndex = 11;
            this.tbMail.Leave += new System.EventHandler(this.tbMail_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(645, 532);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "s";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb17;
        private System.Windows.Forms.RadioButton rb11;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb77;
        private System.Windows.Forms.RadioButton rb53;
        private System.Windows.Forms.RadioButton rb40;
        private System.Windows.Forms.RadioButton rb25;
        private System.Windows.Forms.RadioButton rbSpaylater;
        private System.Windows.Forms.RadioButton rbOvo;
        private System.Windows.Forms.RadioButton rbGopay;
        private System.Windows.Forms.RadioButton rbDana;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

