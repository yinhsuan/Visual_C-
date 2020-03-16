using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace game
{
    public partial class Form1 : Form
    {
        Computer myComputer1 = new Computer();
        public Form1()
        {
            InitializeComponent();
            myComputer1.Audio.Play("..//..//..//..//Resource//Music//background_form1.wav", AudioPlayMode.Background);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(this); //設定Form2為Form1的上層，並開啟Form2視窗
            myComputer1.Audio.Stop();
        }
    }
}
