using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparadorDeMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Filas, Columnas;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (btnCalcular.Text)
            {
                case "Dimensionar":


                    dtgvTras.Columns.Clear();
                    dtgvUno.Columns.Clear();

                    Columnas = Convert.ToInt32(txtColumnas.Text);
                    Filas = Convert.ToInt32(txtFilas.Text);
                    DimensionarMatrices();
                    btnCalcular.Text = "Calcular Traspuesta";

                    break;
                case "Calcular Traspuesta":

                    GenerarTraspuesta();
                    btnCalcular.Text = "Comparar";

                    break;
                case "Comparar":

                    CompararTraspuesta();
                    btnCalcular.Text = "Dimensionar";
                    Filas = 0;
                    Columnas = 0;

                    break;
            }
        }

        private void DimensionarMatrices()
        {
            for (int i = 0; i < Columnas; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "N";
                dtgvUno.Columns.Add(column);
                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "N";
                dtgvTras.Columns.Add(column1);
            }
            dtgvUno.Rows.Add(Filas);
            dtgvTras.Rows.Add(Filas);
        }

        private void GenerarTraspuesta()
        {
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    dtgvTras.Rows[j].Cells[i].Value = dtgvUno.Rows[i].Cells[j].Value;
                }
            }
        }
        private void CompararTraspuesta()
        {
            bool verdadero = true;
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    int datoUno = Convert.ToInt32(dtgvUno.Rows[i].Cells[j].Value);
                    int datoDos = Convert.ToInt32(dtgvTras.Rows[i].Cells[j].Value);

                    if (datoUno == datoDos)
                    {
                        verdadero = true;
                    }
                    else
                    {
                        verdadero = false;
                        break;
                    }
                }
            }

            if (verdadero)
            {
                txtResultado.Text = "La matriz SI es simétrica";
            }
            else
            {
                txtResultado.Text = "La matriz NO es simétrica";
            }
        }
    }
}
