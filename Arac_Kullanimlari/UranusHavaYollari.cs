﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add("Rota:" + comboBox1.Text + " → " + comboBox2.Text + " " + "Tarih:" + dateTimePicker1.Text + " " + "Saat:" + maskedTextBox1.Text + " " + "İsim:" + textBox1.Text + " " + "TC:" + maskedTextBox2.Text + " " + "Telefon:" + maskedTextBox3.Text);

            MessageBox.Show("Biletiniz Rezerve edildi.");
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label10.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama Kapatılmıştır");
            this.Hide();
        }
    }
}
