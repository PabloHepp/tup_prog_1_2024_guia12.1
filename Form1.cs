using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia12_1_Ej2ControlPaso
{
    public partial class Form1 : Form

    {
        Controladora controlador = new Controladora();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            string patente = tbPatente.Text;
            int tipoVehiculo = cbTipoVehiculo.SelectedIndex;
            int modeloVehiculo = Convert.ToInt32(tbAñoFab.Text);
            bool esElectrico = cbElectrico.Checked;

            controlador.RegistrarVehiculo(patente, tipoVehiculo, modeloVehiculo, esElectrico);

            tbPatente.Clear();
            tbAñoFab.Clear();
            cbTipoVehiculo.SelectedIndex = -1;
            cbElectrico.Checked = false;
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEstadistica_Click(object sender, EventArgs e)
        {
            FormResultados resultados = new FormResultados();

            controlador.FiltrarElectricos();

            if(controlador.contadorElectricos>0)
            {
                resultados.lbResultados.Items.Add("Vehículos Electricos:");

                for (int i = 0;i<controlador.contadorElectricos;i++)
                {
                    string patente = controlador.patentesElecricos[i];
                    int modelo = controlador.ModelosElectricos[i];
                    int tipo = controlador.TiposVehiculosElectricos[i];

                    resultados.lbResultados.Items.Add($"\t {patente} - {modelo} - {tipo}");
                    
                }
            }

            else
            {
                resultados.lbResultados.Items.Add("No se registraron vehiculos electricos");
            }

            resultados.ShowDialog();

        }
    }
}
