using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_siniflar_kapsulleme_my
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            araba car2 = new araba();

            car2.renk = "Yeşil";
            car2.hiz = 130;
            car2.motor = 1115.56;
            car2.fiyat = 30000;
            car2.durum = 'i'; //durum değişkeninin türü char olduğu için tek tırnakta yazdık

            label1.Text = car2.renk;
            label2.Text = car2.hiz.ToString();
            label3.Text = car2.motor.ToString();
            label4.Text = car2.fiyat.ToString();
            label5.Text = car2.durum.ToString();
            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}
