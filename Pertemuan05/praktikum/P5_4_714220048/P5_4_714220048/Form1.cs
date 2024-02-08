using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_from_Click(object sender, EventArgs e)
        {

        }

        private void btn_tampilkan_Click(object sender, EventArgs e)
        {
            string jadwal = "";
            string kelas = "";

            if(tb_nama.Text == "")
            {
                MessageBox.Show("Nama harus diisi!",
                    "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if(cb_gender.Text != "Laki-Laki" && cb_gender.Text != "Perempuan")
            {
                MessageBox.Show("Jenis kelamin tidak valid!",
                    "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_biola.Checked)
            {
                kelas += "Biola, ";
            }
            if (cb_gitar.Checked)
            {
                kelas += "Gitar, ";
            }
            if (cb_sax.Checked)
            {
                kelas += "Saxophone, ";
            }
            if (cb_piano.Checked)
            {
                kelas += "piano, ";
            }
            if (cb_kon.Checked)
            {
                kelas += "Konduktor, ";
            }
            if (cb_vokal.Checked)
            {
                kelas += "Vokal, ";
            }
            if (cb_drum.Checked)
            {
                kelas += "Drum, ";
            }
            if (cb_komposer.Checked)
            {
                kelas += "Komposer, ";
            }

            kelas = kelas.TrimEnd(',', ' ');


            if (rb_senin.Checked)
            {
                jadwal += "Senin & Rabu, 14.00-16.00, ";
            }
            if (rb_selasa.Checked)
            {
                jadwal += "Selasa & Kamis, 14.00-16.00, ";
            }
            if (rb_sabtu.Checked)
            {
                jadwal += "Sabtu & Minggu.- 09.00-13.00, ";
            }
            if (rb_minggu.Checked)
            {
                jadwal += "Minggu, 13.00-17.00, ";
            }

            if (string.IsNullOrWhiteSpace(kelas))
            {
                MessageBox.Show("Harus memilih salah satu atau lebih dari pilihan kelas!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(jadwal))
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Nama: " + tb_nama.Text +
                   "\nJenis Kelamin: " + cb_gender.Text +
                   "\nTanggal Lahir: " + dt_kelahiran.Text +
                   "\nPilihan Kelas: " + kelas +
                   "\nPilihan Jadwal: " + jadwal,
                   "\nInformasi Pendaftaran",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gb_piano_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
