using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Formulario_Practica
{
    public partial class Form1 : Form
    {
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            if (mensaje == "")
            {
                MessageBox.Show("Debe ingresar un dato");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btnElegirOpcion_Click(object sender, EventArgs e)
        {
            string optionSelected = comboOpciones.Text;
            MessageBox.Show(optionSelected);
        }

        private void comboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string optionSelected = comboOpciones.Text;
            switch (optionSelected)
            {
                case "Rojo":
                    break;
                case "Azul":
                    break;
                case "Verde":
                    break;
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum1.Text);
            var suma = num1 + num2;
            MessageBox.Show(suma.ToString());
        }
    }
}
