using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarar Variável:
            double altura, basee;

            try
            {
                //Declarar valor da variável:
                altura = double.Parse(txbAltura.Text);
                basee = double.Parse(txbBase.Text);

                //Efetuar a operação:
                txbResultado.Text = ((altura * basee) / 2).ToString();
            }
            catch
            {
                MessageBox.Show("Dados Invalidos Informados!!!");
                //Limpar txb's
                txbBase.Clear();
                txbAltura.Clear();
                txbResultado.Clear();
            }


        }
    }
}
