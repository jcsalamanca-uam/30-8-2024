using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion4
{
    public partial class Form1 : Form
    {
        public int porcentaje { get; set; }
        public Form1()
        {
            InitializeComponent();
            porcentaje = (int) (this.Opacity*100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity=(this.Opacity>=1)?1: this.Opacity+= 0.1;
                        mostrarOpacity();
            this.NudPorcentaje.Value=(int)(this.Opacity*100);
        }

        private void BtnDisminuir_Click(object sender, EventArgs e)
        {
            this.Opacity = (this.Opacity <= 0.2)?1: this.Opacity -= 0.1;
            mostrarOpacity();
            this.NudPorcentaje.Value = (int)(this.Opacity * 100);

        }
        private void mostrarOpacity()
        {
            double OpacityDisplay = Opacity*100;
            this.Text = "";
            this.Text = "Ejemplo 1   " + (this.Opacity * 100).ToString()+"%";
            if (this.Opacity<0.5)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor= Color.Green;
            }
                }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)(NudPorcentaje.Value/100);
            mostrarOpacity();
            ProgressBar1.Value = (int)(NudPorcentaje.Value);
        }
    }
}
