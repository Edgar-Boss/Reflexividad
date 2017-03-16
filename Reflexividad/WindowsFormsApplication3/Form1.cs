using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int[] A=new int[4];
            int[,] R = new int[4, 2];

            A[0] = int.Parse(A1.Text);
            A[1] = int.Parse(A2.Text);
            A[2] = int.Parse(A3.Text);
            A[3] = int.Parse(A4.Text);

            R[0, 0] = int.Parse(R10.Text);
            R[0, 1] = int.Parse(R11.Text);
            R[1, 0] = int.Parse(R20.Text);
            R[1, 1] = int.Parse(R21.Text);
            R[2, 0] = int.Parse(R30.Text);
            R[2, 1] = int.Parse(R31.Text);
            R[3, 0] = int.Parse(R40.Text);
            R[3, 1] = int.Parse(R41.Text);


            int cont = 0;
            for (int k = 0; k < 4; k++)
            {

                for (int j = 0; j < 4; j++)
                {

                    if (A[k] == R[j, 0] && A[k] == R[j, 1])
                    {
                        cont++;

                    }



                }

            }

            if (cont == 4)
                Resultado.Text = "Es reflexiva";
            else
                Resultado.Text = "No es reflexiva";



        }
    }
}
