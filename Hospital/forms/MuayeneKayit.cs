using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class MuayeneKayit : Form
    {
        public MuayeneKayit()
        {
           

            InitializeComponent();
        
            //İstenilen Şekilde saat:dakika alma
            String hourMinute = DateTime.Now.ToString("HH:mm");
            textBox2.Text = hourMinute;

            //Buton Çerçeve Kaldırma
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Hasta Şikayetini Giriniz");
            }
            else
                MessageBox.Show("Muayene Oluşturuldu");
            textBox3.Clear();
        }
    }
}
