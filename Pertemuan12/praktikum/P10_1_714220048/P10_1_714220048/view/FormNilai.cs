﻿using MySql.Data.MySqlClient;
using P10_1_714220048.controller;
using P10_1_714220048.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P10_1_714220048.view
{
    public partial class FormNilai : Form
    {
        Koneksi koneksi = new Koneksi();
        M_nilai m_nilai = new M_nilai();
        string id_nilai;

        public FormNilai()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            //Query DB
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");

            //Mengubah nama header Tabel
            DataNilai.Columns[0].HeaderText = "ID";
            DataNilai.Columns[1].HeaderText = "Matkul";
            DataNilai.Columns[2].HeaderText = "Kategori";
            DataNilai.Columns[3].HeaderText = "NPM";
            DataNilai.Columns[4].HeaderText = "Nama";
            DataNilai.Columns[5].HeaderText = "Nilai";
        }

        private void cbMatkul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataMhs();
        }

        public void GetDataMhs()
        {
            //ambil data NPM dari table (t_mahasiswa) untuk mengisi data pada combobox NPM
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                cbNpm.Items.Add(reader.GetString("npm"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void DataNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nilai = DataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMatkul.Text = DataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbKategori.Text = DataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbNpm.Text = DataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbNilai.Text = DataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query search data
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
            
             "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm " +
             "WHERE t_nilai.npm LIKE '%' '" + tbCariData.Text + "' '%' " +
             "OR nama LIKE '%' '" + tbCariData.Text + "' '%'" +
             "OR matkul LIKE '%' '" + tbCariData.Text + "' '%'");

        }

        public void GetNamaMhs()
        {
            //ambil data nama ketika combobox npm dipilih
            koneksi.OpenConnection();
           MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa WHERE npm = '" + cbNpm.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbNama.Text = reader.GetString(0);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void ResetForm()
        {
            cbMatkul.SelectedIndex = -1;
            cbKategori.SelectedIndex = -1;
            cbNpm.SelectedIndex = -1;
            tbNilai.Text = "";
            tbNama.Text = "";
            tbCariData.Text = "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbNpm_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbKategori.SelectedIndex == -1 ||cbNpm.SelectedIndex == -1 || tbNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = cbMatkul.Text;
                m_nilai.Kategori = cbKategori.Text;
                m_nilai.Npm = cbNpm.Text;
                m_nilai.Nilai = tbNilai.Text;
                nilai.Insert(m_nilai);
                ResetForm();
                Tampil();
            }

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbKategori.SelectedIndex == -1 ||cbNpm.SelectedIndex == -1 || tbNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = cbMatkul.Text;
                m_nilai.Kategori = cbKategori.Text;
                m_nilai.Npm = cbNpm.Text;
                m_nilai.Nilai = tbNilai.Text;
                nilai.Update(m_nilai, id_nilai);
                ResetForm();
                Tampil();
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?","Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id_nilai);
                ResetForm();
                Tampil();
            }

        }
    }
}
