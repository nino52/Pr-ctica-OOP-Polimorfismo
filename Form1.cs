using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculandoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario = 0;
            double tarifaPorHora = 800;
            double horasTrabajadas;
            double bonificacion = 0.5; // 50% de bonificación
            double meta = 1000; // Asumimos una meta para el cálculo

            // Obtener horas trabajadas
            if (double.TryParse(txtHorasTrabajadas.Text, out horasTrabajadas))
            {
                // Determinar el tipo de empleado
                string tipoEmpleado = cmbTipoEmpleado.SelectedItem.ToString();

                switch (tipoEmpleado)
                {
                    case "Docente por hora":
                        salario = horasTrabajadas * tarifaPorHora;
                        break;

                    case "Docente de contrato fijo":
                        salario = (horasTrabajadas >= meta) ? 2000 : 1000; // Asumimos un salario fijo
                        break;

                    case "Empleado administrativo":
                        salario = (horasTrabajadas >= meta) ? 1500 : 750; // Asumimos un salario fijo
                        break;
                }

                lblSalario.Text = $"Salario: {salario:C}"; // Muestra el salario en formato de moneda
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido de horas trabajadas.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
