namespace P5_4_714220048
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
            this.label_nama = new System.Windows.Forms.Label();
            this.label_gander = new System.Windows.Forms.Label();
            this.label_kelahiran = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.dt_kelahiran = new System.Windows.Forms.DateTimePicker();
            this.gb_kelas = new System.Windows.Forms.GroupBox();
            this.cb_komposer = new System.Windows.Forms.CheckBox();
            this.cb_kon = new System.Windows.Forms.CheckBox();
            this.cb_vokal = new System.Windows.Forms.CheckBox();
            this.cb_sax = new System.Windows.Forms.CheckBox();
            this.cb_drum = new System.Windows.Forms.CheckBox();
            this.cb_gitar = new System.Windows.Forms.CheckBox();
            this.cb_piano = new System.Windows.Forms.CheckBox();
            this.cb_biola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_minggu = new System.Windows.Forms.RadioButton();
            this.rb_sabtu = new System.Windows.Forms.RadioButton();
            this.rb_senin = new System.Windows.Forms.RadioButton();
            this.rb_selasa = new System.Windows.Forms.RadioButton();
            this.btn_tampilkan = new System.Windows.Forms.Button();
            this.btn_selesai = new System.Windows.Forms.Button();
            this.label_from = new System.Windows.Forms.Label();
            this.gb_kelas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.Location = new System.Drawing.Point(104, 82);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(42, 18);
            this.label_nama.TabIndex = 0;
            this.label_nama.Text = "Name";
            // 
            // label_gander
            // 
            this.label_gander.AutoSize = true;
            this.label_gander.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gander.Location = new System.Drawing.Point(104, 123);
            this.label_gander.Name = "label_gander";
            this.label_gander.Size = new System.Drawing.Size(93, 18);
            this.label_gander.TabIndex = 1;
            this.label_gander.Text = "Jenis Kelamin";
            // 
            // label_kelahiran
            // 
            this.label_kelahiran.AutoSize = true;
            this.label_kelahiran.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kelahiran.Location = new System.Drawing.Point(104, 164);
            this.label_kelahiran.Name = "label_kelahiran";
            this.label_kelahiran.Size = new System.Drawing.Size(91, 18);
            this.label_kelahiran.TabIndex = 2;
            this.label_kelahiran.Text = "Tanggal Lahir";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(332, 75);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(182, 20);
            this.tb_nama.TabIndex = 3;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cb_gender.Location = new System.Drawing.Point(332, 115);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(121, 21);
            this.cb_gender.TabIndex = 4;
            this.cb_gender.Text = "--Pilih Jenis Kelamin--";
            // 
            // dt_kelahiran
            // 
            this.dt_kelahiran.Location = new System.Drawing.Point(332, 164);
            this.dt_kelahiran.Name = "dt_kelahiran";
            this.dt_kelahiran.Size = new System.Drawing.Size(200, 20);
            this.dt_kelahiran.TabIndex = 5;
            // 
            // gb_kelas
            // 
            this.gb_kelas.Controls.Add(this.cb_komposer);
            this.gb_kelas.Controls.Add(this.cb_kon);
            this.gb_kelas.Controls.Add(this.cb_vokal);
            this.gb_kelas.Controls.Add(this.cb_sax);
            this.gb_kelas.Controls.Add(this.cb_drum);
            this.gb_kelas.Controls.Add(this.cb_gitar);
            this.gb_kelas.Controls.Add(this.cb_piano);
            this.gb_kelas.Controls.Add(this.cb_biola);
            this.gb_kelas.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_kelas.Location = new System.Drawing.Point(75, 226);
            this.gb_kelas.Name = "gb_kelas";
            this.gb_kelas.Size = new System.Drawing.Size(238, 154);
            this.gb_kelas.TabIndex = 6;
            this.gb_kelas.TabStop = false;
            this.gb_kelas.Text = "Pilih Kelas";
            // 
            // cb_komposer
            // 
            this.cb_komposer.AutoSize = true;
            this.cb_komposer.Location = new System.Drawing.Point(108, 118);
            this.cb_komposer.Name = "cb_komposer";
            this.cb_komposer.Size = new System.Drawing.Size(87, 22);
            this.cb_komposer.TabIndex = 7;
            this.cb_komposer.Text = "Komposer";
            this.cb_komposer.UseVisualStyleBackColor = true;
            // 
            // cb_kon
            // 
            this.cb_kon.AutoSize = true;
            this.cb_kon.Location = new System.Drawing.Point(6, 118);
            this.cb_kon.Name = "cb_kon";
            this.cb_kon.Size = new System.Drawing.Size(91, 22);
            this.cb_kon.TabIndex = 6;
            this.cb_kon.Text = "Konduktor";
            this.cb_kon.UseVisualStyleBackColor = true;
            // 
            // cb_vokal
            // 
            this.cb_vokal.AutoSize = true;
            this.cb_vokal.Location = new System.Drawing.Point(109, 90);
            this.cb_vokal.Name = "cb_vokal";
            this.cb_vokal.Size = new System.Drawing.Size(59, 22);
            this.cb_vokal.TabIndex = 5;
            this.cb_vokal.Text = "Vokal";
            this.cb_vokal.UseVisualStyleBackColor = true;
            // 
            // cb_sax
            // 
            this.cb_sax.AutoSize = true;
            this.cb_sax.Location = new System.Drawing.Point(6, 90);
            this.cb_sax.Name = "cb_sax";
            this.cb_sax.Size = new System.Drawing.Size(93, 22);
            this.cb_sax.TabIndex = 4;
            this.cb_sax.Text = "Saxophone";
            this.cb_sax.UseVisualStyleBackColor = true;
            // 
            // cb_drum
            // 
            this.cb_drum.AutoSize = true;
            this.cb_drum.Location = new System.Drawing.Point(108, 62);
            this.cb_drum.Name = "cb_drum";
            this.cb_drum.Size = new System.Drawing.Size(60, 22);
            this.cb_drum.TabIndex = 3;
            this.cb_drum.Text = "Drum";
            this.cb_drum.UseVisualStyleBackColor = true;
            // 
            // cb_gitar
            // 
            this.cb_gitar.AutoSize = true;
            this.cb_gitar.Location = new System.Drawing.Point(6, 62);
            this.cb_gitar.Name = "cb_gitar";
            this.cb_gitar.Size = new System.Drawing.Size(58, 22);
            this.cb_gitar.TabIndex = 2;
            this.cb_gitar.Text = "Gitar";
            this.cb_gitar.UseVisualStyleBackColor = true;
            // 
            // cb_piano
            // 
            this.cb_piano.AutoSize = true;
            this.cb_piano.Location = new System.Drawing.Point(109, 34);
            this.cb_piano.Name = "cb_piano";
            this.cb_piano.Size = new System.Drawing.Size(61, 22);
            this.cb_piano.TabIndex = 1;
            this.cb_piano.Text = "Piano";
            this.cb_piano.UseVisualStyleBackColor = true;
            this.cb_piano.CheckedChanged += new System.EventHandler(this.gb_piano_CheckedChanged);
            // 
            // cb_biola
            // 
            this.cb_biola.AutoSize = true;
            this.cb_biola.Location = new System.Drawing.Point(7, 34);
            this.cb_biola.Name = "cb_biola";
            this.cb_biola.Size = new System.Drawing.Size(57, 22);
            this.cb_biola.TabIndex = 0;
            this.cb_biola.Text = "Biola";
            this.cb_biola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_minggu);
            this.groupBox2.Controls.Add(this.rb_sabtu);
            this.groupBox2.Controls.Add(this.rb_senin);
            this.groupBox2.Controls.Add(this.rb_selasa);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(378, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 154);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Jadwal";
            // 
            // rb_minggu
            // 
            this.rb_minggu.AutoSize = true;
            this.rb_minggu.Location = new System.Drawing.Point(19, 109);
            this.rb_minggu.Name = "rb_minggu";
            this.rb_minggu.Size = new System.Drawing.Size(158, 22);
            this.rb_minggu.TabIndex = 3;
            this.rb_minggu.TabStop = true;
            this.rb_minggu.Text = "Minggu, 13.00-17.00";
            this.rb_minggu.UseVisualStyleBackColor = true;
            // 
            // rb_sabtu
            // 
            this.rb_sabtu.AutoSize = true;
            this.rb_sabtu.Location = new System.Drawing.Point(19, 81);
            this.rb_sabtu.Name = "rb_sabtu";
            this.rb_sabtu.Size = new System.Drawing.Size(206, 22);
            this.rb_sabtu.TabIndex = 2;
            this.rb_sabtu.TabStop = true;
            this.rb_sabtu.Text = "Sabtu & Minggu.- 09.00-13.00";
            this.rb_sabtu.UseVisualStyleBackColor = true;
            // 
            // rb_senin
            // 
            this.rb_senin.AutoSize = true;
            this.rb_senin.Location = new System.Drawing.Point(19, 26);
            this.rb_senin.Name = "rb_senin";
            this.rb_senin.Size = new System.Drawing.Size(187, 22);
            this.rb_senin.TabIndex = 1;
            this.rb_senin.TabStop = true;
            this.rb_senin.Text = "Senin & Rabu, 14.00-16.00";
            this.rb_senin.UseVisualStyleBackColor = true;
            // 
            // rb_selasa
            // 
            this.rb_selasa.AutoSize = true;
            this.rb_selasa.Location = new System.Drawing.Point(19, 53);
            this.rb_selasa.Name = "rb_selasa";
            this.rb_selasa.Size = new System.Drawing.Size(196, 22);
            this.rb_selasa.TabIndex = 0;
            this.rb_selasa.TabStop = true;
            this.rb_selasa.Text = "Selasa & Kamis, 14.00-16.00";
            this.rb_selasa.UseVisualStyleBackColor = true;
            // 
            // btn_tampilkan
            // 
            this.btn_tampilkan.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tampilkan.Location = new System.Drawing.Point(238, 386);
            this.btn_tampilkan.Name = "btn_tampilkan";
            this.btn_tampilkan.Size = new System.Drawing.Size(75, 23);
            this.btn_tampilkan.TabIndex = 8;
            this.btn_tampilkan.Text = "Tampilkan";
            this.btn_tampilkan.UseVisualStyleBackColor = true;
            this.btn_tampilkan.Click += new System.EventHandler(this.btn_tampilkan_Click);
            // 
            // btn_selesai
            // 
            this.btn_selesai.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selesai.Location = new System.Drawing.Point(378, 386);
            this.btn_selesai.Name = "btn_selesai";
            this.btn_selesai.Size = new System.Drawing.Size(75, 23);
            this.btn_selesai.TabIndex = 9;
            this.btn_selesai.Text = "Selesai";
            this.btn_selesai.UseVisualStyleBackColor = true;
            this.btn_selesai.Click += new System.EventHandler(this.btn_selesai_Click);
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.Color.Brown;
            this.label_from.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_from.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_from.Location = new System.Drawing.Point(234, 29);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(197, 26);
            this.label_from.TabIndex = 10;
            this.label_from.Text = "FROM PENDAFTARAN";
            this.label_from.Click += new System.EventHandler(this.label_from_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.btn_selesai);
            this.Controls.Add(this.btn_tampilkan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_kelas);
            this.Controls.Add(this.dt_kelahiran);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label_kelahiran);
            this.Controls.Add(this.label_gander);
            this.Controls.Add(this.label_nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_kelas.ResumeLayout(false);
            this.gb_kelas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_gander;
        private System.Windows.Forms.Label label_kelahiran;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.DateTimePicker dt_kelahiran;
        private System.Windows.Forms.GroupBox gb_kelas;
        private System.Windows.Forms.CheckBox cb_komposer;
        private System.Windows.Forms.CheckBox cb_kon;
        private System.Windows.Forms.CheckBox cb_vokal;
        private System.Windows.Forms.CheckBox cb_sax;
        private System.Windows.Forms.CheckBox cb_drum;
        private System.Windows.Forms.CheckBox cb_gitar;
        private System.Windows.Forms.CheckBox cb_piano;
        private System.Windows.Forms.CheckBox cb_biola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_minggu;
        private System.Windows.Forms.RadioButton rb_sabtu;
        private System.Windows.Forms.RadioButton rb_senin;
        private System.Windows.Forms.RadioButton rb_selasa;
        private System.Windows.Forms.Button btn_tampilkan;
        private System.Windows.Forms.Button btn_selesai;
        private System.Windows.Forms.Label label_from;
    }
}

