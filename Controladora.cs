using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Guia12_1_Ej2ControlPaso
{
    public class Controladora
    {
        public string[] patentes = new string[300];
        public int[] TiposVehiculos = new int[300];
        public bool[] SonElectricos = new bool[300];
        public int[] modelos = new int[300];
        public int contador = 0;

        public string[] patentesElecricos = new string[300];
        public int[] TiposVehiculosElectricos = new int[300];
        public int[] ModelosElectricos = new int[300];
        public int contadorElectricos = 0;
        
        public void RegistrarVehiculo(string patente, int tipo, int modelo, bool esElectrico)
        {
            patentes[contador] = patente;
            TiposVehiculos[contador] = tipo;
            SonElectricos[contador] = esElectrico;
            modelos[contador] = modelo;
            contador++;
        }

        public void FiltrarElectricos()
        {
            int contadorElectricos = 0;

            for(int i=0; i < contador; i++)
            {
                if (SonElectricos[i]==true)
                {
                    patentesElecricos[contadorElectricos] = patentes[i];
                    ModelosElectricos[contadorElectricos] = modelos[i];
                    TiposVehiculosElectricos[contadorElectricos] = TiposVehiculos[i];
                    contadorElectricos++;

                }
            }

            OrdenarElectricos();

        }

        public void OrdenarElectricos()
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < contadorElectricos - 1; i++)
            {
                for (j = i + 1; j < contadorElectricos; j++)
                {
                    if (ModelosElectricos[i] > ModelosElectricos[j])
                    {
                        string auxpatente = patentesElecricos[i];
                        patentesElecricos[i] = patentesElecricos[j];
                        patentesElecricos[j] = auxpatente;

                        int auxmodelo = ModelosElectricos[i];
                        ModelosElectricos[i] = ModelosElectricos[j];
                        ModelosElectricos[j] = auxmodelo;

                        int auxtipo = TiposVehiculosElectricos[i];
                        TiposVehiculosElectricos[i] = TiposVehiculosElectricos[j];
                        TiposVehiculosElectricos[j] = auxtipo;

                    }
                }
            }

        }

    }

    


}
