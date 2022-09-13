using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Ejercicio
{
   
    public partial class Form1 : Form
    {
        private double num2;
        private double num1;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtTotal.Clear();
        }

        private void comboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string optionSelected = comboOpciones.Text;
            MessageBox.Show(optionSelected);

            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            double r = 0;
            switch (optionSelected)
            {
                case "SUMA":
                    r = num1 + num2;
                    break;

                case "RESTA":
                    r = num1 - num2;
                    break;
                    

                case "MULTIPLICACION":
                    r = num1 * num2;
                    break;

                case "DIVISION":
                    if (num2 != 0)
                    {
                        r = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre CERO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txtNum1.Clear();
                        txtNum2.Clear();
                        txtTotal.Clear();
                    }
                    break;
            }
            txtTotal.Text = r.ToString();
        }
    }
}
