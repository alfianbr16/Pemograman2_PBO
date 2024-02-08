using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string Item = "";
            string Pembayaran = "";

            if (tbName.Text == "")
            {
                MessageBox.Show("Nama Depan harus diisi",
                           "Warning!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbId.Text == "")
            {
                MessageBox.Show("User ID harus diisi",
                           "Warning!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbMail.Text == "")
            {
                MessageBox.Show("E-Mail harus diisi",
                           "Warning!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (rb3.Checked)
            {
                Item += "3 Diamonds\r\nRp.1.300, ";
            }
            if (rb5.Checked)
            {
                Item += "5 Diamonds\r\nRp.1.579, ";
            }
            if (rb11.Checked)
            {
                Item += "11 Diamonds + 1 Bonus\r\nRp.3.688, ";
            }
            if (rb17.Checked)
            {
                Item += "17 Diamonds + 2 Bonus\r\nRp.5.797, ";
            }
            if (rb25.Checked)
            {
                Item += "25 Diamonds + 3 Bonus\r\nRp.8.346, ";
            }
            if (rb40.Checked)
            {
                Item += "40 Diamonds + 4 Bonus\r\nRp.12.654, ";
            }
            if (rb53.Checked)
            {
                Item += "53 Diamonds + 6 Bonus\r\nRp.16.872, ";
            }
            if (rb77.Checked)
            {
                Item += "77 Diamonds + 8 Bonus\r\nRp.24.254, ";
            }

            Item = Item.TrimEnd(',', ' ');


            if (rbDana.Checked)
            {
                Pembayaran += "DANA, ";
            }
            if (rbGopay.Checked)
            {
                Pembayaran += "GO-PAY, ";
            }
            if (rbOvo.Checked)
            {
                Pembayaran += "OVO, ";
            }
            if (rbSpaylater.Checked)
            {
                Pembayaran += "SPayLater, ";
            }

            if (string.IsNullOrWhiteSpace(Item))
            {
                MessageBox.Show("Harus memilih salah satu atau lebih dari pilihan Item!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Pembayaran))
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan Pembayaran!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Nama: " + tbName.Text +
            "\nUser Id: " + tbId.Text +
            "\nAlamat E-mail: " + tbMail.Text +
            "\nPilihan Item: " + Item +
            "\nPilihan Pembayaran: " + Pembayaran,
            "\nInformasi Pendaftaran",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            String inputNama = tbName.Text;

            if (String.IsNullOrEmpty(inputNama))
            {
                epWarning.SetError(tbName, "Text Box Tidak Boleh Kosong!");
                epWrong.SetError(tbName, "");
                epCorrect.SetError(tbName, "");
            }
            else
            {
                if (char.IsUpper(inputNama[0]) && inputNama.Substring(1).All(Char.IsLetter))
                { 
                    epWarning.SetError(tbName, "");
                    epWrong.SetError(tbName, "");
                    epCorrect.SetError(tbName, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbName, "Inputan hanya boleh diawali dengan huruf kapital dan haya berisi huruf!");
                    epWarning.SetError(tbName, "");
                    epCorrect.SetError(tbName, "");
                }
            }
        }

        private void tbId_Leave(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                epWarning.SetError(tbId, "Text Box Tidak Boleh Kosong!");
                epWrong.SetError(tbId, "");
                epCorrect.SetError(tbId, "");
            }
            else
            {
                if ((tbId.Text).All(Char.IsNumber))
                {
                    if (tbId.Text.Length >= 8 && tbId.Text.Length <= 10)
                    { 
                        epWarning.SetError(tbId, "");
                        epWrong.SetError(tbId, "");
                        epCorrect.SetError(tbId, "Betul!");
                    }
                    else
                    {
                        epWrong.SetError(tbId, "");
                        epWarning.SetError(tbId, "User Id harus memiliki setidaknya 8 digit!\nMax 10 digit.");
                        epCorrect.SetError(tbId, "");
                    }
                }
                else
                {
                    epWrong.SetError(tbId, "User Id tidak valid!\nInput hanya boleh angka.");
                    epWarning.SetError(tbId, "");
                    epCorrect.SetError(tbId, "");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbMail_Leave(object sender, EventArgs e)
        {
            String inputMail = tbMail.Text;
            if (Regex.IsMatch(tbMail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$") && Char.IsLower(inputMail[0]))
            {
                epWarning.SetError(tbMail, "");
                epWrong.SetError(tbMail, "");
                epCorrect.SetError(tbMail, "Betul!");
            }
            else
            {
                if (Regex.IsMatch(tbMail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$") && Char.IsUpper(inputMail[0]))
                {
                    epWarning.SetError(tbMail, "Text Box Tidak Boleh Kosong!");
                    epWrong.SetError(tbMail, "");
                    epCorrect.SetError(tbMail, "");
                }
                else
                {
                    epWrong.SetError(tbMail, "Format email salah!\nContoh: a@b.c");
                    epWarning.SetError(tbMail, "");
                    epCorrect.SetError(tbMail, "");
                }
            } 
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
