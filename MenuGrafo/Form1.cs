using Dijkstra;
using Gestores.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MenuGrafo
{
    public partial class Form1 : Form
    {
        public GestorGrafo gestorg;

        public Form1()
        {
            gestorg = new GestorGrafo();
            InitializeComponent();
            UpdateCbox();

        }

        private void UpdateCbox()
        {
            comboBox1.Items.Clear();
            comboBox3.Items.Clear();
            var l = gestorg.GetAllVerticesName();
            String[] orderedlist = l.ToArray();
            Array.Sort(orderedlist);

            foreach (String n in orderedlist)
            {
                comboBox1.Items.Add(n);
            }

            comboBox3.Items.AddRange(comboBox1.Items.Cast<Object>().ToArray());
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                FillOutput("El campo de vertice no puede estar vacío", Color.Red);
            }
            else
            {
                var v = gestorg.AddVertice(textBox1.Text);
                textBox1.Clear();
                if (v == null)
                {
                    FillOutput("Un vertice con ese nombre ya existe", Color.Red);
                }
                else
                {
                    FillOutput("El vertice fue agregado", Color.Green);
                    UpdateCbox();
                }

            }

        }

        private void FillOutput(String text, Color c)
        {
            richTextBox1.Clear();
            richTextBox1.Text = text;
            richTextBox1.ForeColor = c;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(comboBox1.Items.Cast<Object>().ToArray());
            comboBox2.Items.Remove(comboBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String s = "";
            Color c;

            if (comboBox3.SelectedIndex == -1)
            {

                s = "Favor seleccione un elemento de la lista";
                c = Color.Red;
            }
            else
            {
                var l = gestorg.buscarAdyacentes(comboBox3.SelectedItem.ToString());
                if (l.Count != 0)
                {
                    foreach (Arco a in l)
                    {
                        s += "Vertice: " + a.child.nombre + " Distancia: " + a.distancia + "km\n";
                    }

                    c = Color.Black;
                }
                else
                {
                    s = "El vértice ingresado no tiene arcos";
                    c = Color.Red;
                }

            }

            FillOutput(s,c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s;
            Color c;
            if(comboBox1.SelectedIndex == -1)
            {
                s = "El campo de origen no debe ser vacío";
                c = Color.Red;
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                s = "El campo de destino no debe ser vacío";
                c = Color.Red;
            }else if (numericUpDown1.Value <= 0)
            {
                s = "El campo de distancia debe de ser mayor a cero";
                c = Color.Red;
            }
            else
            {
                var a = gestorg.AddArco(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), (int)numericUpDown1.Value);
                if(a != null)
                {
                    s = "El arco entre: " + a.parent.nombre + " -> " + a.child.nombre + " con distancia: " + a.distancia + "km ha sido agregado.";
                    c = Color.Green;
                }
                else
                {
                    s = "Ya existe un arco entre: " + comboBox1.SelectedItem.ToString() + " -> " + comboBox2.SelectedItem.ToString();
                    c = Color.Red;
                }
            }

            FillOutput(s, c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s;
            Color c;
            if (comboBox1.SelectedIndex == -1)
            {
                s = "El campo de origen no debe ser vacío";
                c = Color.Red;
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                s = "El campo de destino no debe ser vacío";
                c = Color.Red;
            }
            else
            {
                s=gestorg.calcularCamino(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                c = Color.Black;
            }

            FillOutput(s, c);
        }
    }
}
