﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "brandon@upt.com"; 
            string pass = "0987654321";
            string Cusuario = txbUsuario.Text;
            string Cpass = txbContrasenia.Text;


            if ( Cusuario == usuario && Cpass == pass)
            {
                Form2 des = new Form2();
                des.Show();
            }
            else
            {
                label2.Text = "El Usuario u Contraseña son incorrectos";
            }
            

        }
    }
}