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
    public partial class SekreterGiris : Form
    {
        public SekreterGiris()
        {
            InitializeComponent();
        }

        private void SekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HastaKayıt sayfa = new HastaKayıt();
            sayfa.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
              MuayeneKayit sayfa = new MuayeneKayit();
            sayfa.ShowDialog();
        }

        }
    }

