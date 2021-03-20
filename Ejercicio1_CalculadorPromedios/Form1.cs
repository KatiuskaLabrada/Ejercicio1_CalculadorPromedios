using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_CalculadorPromedios
{
    public partial class Form1 : Form
    {
        //Declaracion de las variables
        double val1, val2, val3, valSum, prom;

        //Función que cierra la aplicación
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Función que limpia todos loc campos
        private void btnClear_Click(object sender, EventArgs e)
        {
            cal1.Clear();
            cal2.Clear();
            cal3.Clear();
            res.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Función que calcula el promedio de 3 notas
        private void btnCal_Click(object sender, EventArgs e)
        {
            //Asigna valores a las variables
            val1 = Convert.ToDouble(cal1.Text);
            val2 = Convert.ToDouble(cal2.Text);
            val3 = Convert.ToDouble(cal3.Text);

            //Calculos matematicos
            valSum = val1 + val2 + val3;
            prom = valSum / 3;

            //Mostrar los resultados
            this.res.Text = prom.ToString("N1");
        }
    }
}
