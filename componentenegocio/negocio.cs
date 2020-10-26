using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librerianegocio;
namespace componentenegocio
{
    public partial class negocio : UserControl
    {
        public negocio()
        {
            InitializeComponent();
        }
        string nombre;
        string producto;
        string cuatro;
        private void button1_Click(object sender, EventArgs e)
        {
          
            nombre = textBox1.Text;
            producto = textBox2.Text;
            double tres = double.Parse(textBox3.Text);
            
            double precio = double.Parse(textBox5.Text);

            double total = opera.total(tres,precio);
            


            
            
            MessageBox.Show("Sus datos:"+" su nombre es "+nombre+","+" ha comprado "+ producto+ ","+" por la cantidad de "+tres.ToString()+" y precio del producto es "+ precio.ToString() +","+ "el total "+total.ToString());
            
              textBox4.Text =   opera.registroo(nombre,producto,tres.ToString(),cuatro,precio.ToString(),total.ToString());
              textBox6.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "0.0";
            textBox4.Clear();
            textBox5.Text = "0.0";
            textBox6.Text = "0.0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
