using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Clave = Convert.ToInt32(textBox1.Text);
            using (EntendiLaReferencia.Service1Client Producto = new EntendiLaReferencia.Service1Client())
            {
                var producto = Producto.GetInventario(Clave);
                var nombre = producto.Nom_Producto;
                var cantidad = producto.Cantidad;
                var codigo = producto.Codigo;

                textBox2.Text = nombre;
                textBox3.Text = cantidad;
                textBox4.Text = codigo;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Inventario";
            label1.Text = "Clave:";
            label3.Text = "Nombre:";
            label4.Text = "Cantidad";
            label5.Text = "Clave";
            label6.Visible = false;


            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button1.Visible = true;

            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            button5.Visible = false;

            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox8.Text);
            using (EntendiLaReferencia.Service1Client AL = new EntendiLaReferencia.Service1Client())
            {
                var alumno = AL.GetAlumno(ID);
                var nombre = alumno.Nombre;
                var apellido = alumno.Apellidos;
                var nc = alumno.Num_Control;
                var califa = alumno.Calificacion;

                textBox5.Text = nombre;
                textBox6.Text = apellido;
                textBox7.Text = nc;
                textBox9.Text = Convert.ToString(califa);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Alumnos";
            label1.Text = "ID:";
            label3.Text = "Nombre:";
            label4.Text = "Apellidos:";
            label5.Text = "N. Control:";
            label6.Visible = true;
            label6.Text = "Calificación:";

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;

            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            button5.Visible = true;

            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            button6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox10.Text);
            using (EntendiLaReferencia.Service1Client DIST = new EntendiLaReferencia.Service1Client())
            {
                var distribuidor = DIST.GetDistribuidor(ID);
                var nombre = distribuidor.Nombre;
                var apellidos = distribuidor.Apellidos;
                var entrega = distribuidor.Entrega;

                textBox11.Text = nombre;
                textBox12.Text = apellidos;
                textBox13.Text = entrega;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            label2.Text = "Distribuidores";
            label1.Text = "ID:";
            label3.Text = "Nombre:";
            label4.Text = "Apellidos";
            label5.Text = "Entrega";
            label6.Visible = false;
            label6.Text = "Calificación:";

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;

            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            button5.Visible = false;

            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            button6.Visible = true;
        }
    }
}
