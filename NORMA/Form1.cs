using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Bitmap img = new Bitmap(Application.StartupPath + @"C:\Users\junio\Downloads\fondocasa.jpeg");
            Bitmap img = new Bitmap(@"C:\Users\junio\Downloads\fondocasa.jpeg");

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panelLuz.BackColor = Color.Green; // Encendido
            }
            else
            {
                panelLuz.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                panel1.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel1.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                panel2.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel2.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                panel5.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel5.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                panel4.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel4.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                panel3.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel3.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                panel14.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel14.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                panel13.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel13.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                panel12.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel12.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                panel9.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel9.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                panel10.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel10.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                panel11.BackColor = Color.Green; // Encendido
            }
            else
            {
                panel11.BackColor = Color.Gray; // Apagado
            }
            CheckAllCheckboxes();
        }
        // Nueva función para verificar todos los checkboxes
        private void CheckAllCheckboxes()
        {
            // Lista de todos los checkboxes en el formulario
            var checkboxes = new List<CheckBox> { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6,
                                          checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12 };

            // Verifica si todos están marcados
            if (checkboxes.All(cb => cb.Checked))
            {
                // Cambia todos los paneles a rojo
                panelLuz.BackColor = Color.Red;
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
                panel3.BackColor = Color.Red;
                panel4.BackColor = Color.Red;
                panel5.BackColor = Color.Red;
                panel9.BackColor = Color.Red;
                panel10.BackColor = Color.Red;
                panel11.BackColor = Color.Red;
                panel12.BackColor = Color.Red;
                panel13.BackColor = Color.Red;
                panel14.BackColor = Color.Red;
            }
        }
    }
}
