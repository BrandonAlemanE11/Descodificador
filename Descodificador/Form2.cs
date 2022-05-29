using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descodificador
{
    public partial class Form2 : Form
    {

        public static string[] fraseC = new string[3];
        public static int[] frase = new int[3];
        string nueva, antes;
        int resu;
        double suma, suma2, suma3, aa, bb, cc, resultado;
        string a, b, c;
        

        public Form2()
        {
            //Form1 login = new Form1();
            //login.Close();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = nueva;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            antes = "";
            nueva = "";
            label2.Text = "Mensaje cifrado";
            label1.Text = "Mensaje Desifrado";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fra = textBox1.Text;
            fraseC = fra.Split(' ');
            a = fraseC[0];
            aa = Convert.ToDouble(a);
            b = fraseC[1];
            bb = Convert.ToDouble(b);
            c = fraseC[2];
            cc = Convert.ToDouble(c);
            l1();
            l2();
            l3();
            Letra();
            label1.Text = antes;
            textBox1.Text = "";
        }

        private void l1()
        {
            suma = -0.27272727 * aa;
            suma2 = 0.545454545 * bb;
            suma3 = 0.181818181 * cc;
            resultado = suma + suma2 + suma3;
            resu = Convert.ToInt32(resultado);
            antes = antes + " " + resu;
            frase[0] = resu;
        }

        private void l2()
        {
            suma = 0.090909090 * aa;
            suma2 = -0.18181818 * bb;
            suma3 = 0.272727272 * cc;
            resultado = suma + suma2 + suma3;
            resu = Convert.ToInt32(resultado);
            antes = antes + " " + resu;
            frase[1] = resu;
        }
        private void l3()
        {
            suma = 0.636363636 * aa;
            suma2 = -0.27272727 * bb;
            suma3 = -0.09090909 * cc;
            resultado = suma + suma2 + suma3;
            resu = Convert.ToInt32(resultado);
            antes = antes + " " + resu;
            frase[2] = resu;
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        public void Letra()
        {
            foreach (int letra in frase)
            {
                if (letra == 0)
                {
                    nueva = nueva + "" + " ";
                }
                if (letra == 1)
                {
                    nueva = nueva + "" + "A";
                }
                if (letra == 2)
                {
                    nueva = nueva + "" + "B";
                }
                if (letra == 3)
                {
                    nueva = nueva + "" + "C";
                }
                if (letra == 4)
                {
                    nueva = nueva + "" + "D";
                }
                if (letra == 5)
                {
                    nueva = nueva + "" + "E";
                }
                if (letra == 6)
                {
                    nueva = nueva + "" + "F";
                }
                if (letra == 7)
                {
                    nueva = nueva + "" + "G";
                }
                if (letra == 8 )
                {
                    nueva = nueva + "" + "H";
                }
                if (letra == 9)
                {
                    nueva = nueva + "" + "I";
                }
                if (letra == 10)
                {
                    nueva = nueva + "" + "J";
                }
                if (letra == 11)
                {
                    nueva = nueva + "" + "K";
                }
                if (letra == 12)
                {
                    nueva = nueva + "" + "L";
                }
                if (letra == 13)
                {
                    nueva = nueva + "" + "M";
                }
                if (letra == 14)
                {
                    nueva = nueva + "" + "N";
                }
                if (letra == 15)
                {
                    nueva = nueva + "" + "Ñ";
                }
                if (letra == 16)
                {
                    nueva = nueva + "" + "O";
                }
                if (letra == 17)
                {
                    nueva = nueva + "" + "P";
                }
                if (letra == 18)
                {
                    nueva = nueva + "" + "Q";
                }
                if (letra == 19)
                {
                    nueva = nueva + "" + "R";
                }
                if (letra == 20)
                {
                    nueva = nueva + "" + "S";
                }
                if (letra == 21)
                {
                    nueva = nueva + "" + "T";
                }
                if (letra == 22)
                {
                    nueva = nueva + "" + "U";
                }
                if (letra == 23)
                {
                    nueva = nueva + "" + "V";
                }
                if (letra == 24)
                {
                    nueva = nueva + "" + "W";
                }
                if (letra == 25)
                {
                    nueva = nueva + "" + "X";
                }
                if (letra == 26)
                {
                    nueva = nueva + "" + "Y";
                }
                if (letra == 26)
                {
                    nueva = nueva + "" + "Z";
                }
            }
          
        }
    }
}
