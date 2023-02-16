using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_01
{
    public partial class Form1 : Form
    {
        

        SqlConnection conn = new SqlConnection("Data Source=OSA0625241W10-1;Initial Catalog=Media_alunos;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
            Carregarlista();
        }

        private void Carregarlista()
        {
            listB_Nome.Items.Clear();
            listB_Nota_1.Items.Clear();
            listB_Nota_3.Items.Clear();
            listB_Nota_4.Items.Clear();
            listB_Nota_5.Items.Clear();
            listB_Nota_6.Items.Clear();
            listB_Nota_7.Items.Clear();
            listB_Nota_8.Items.Clear();

            conn.Open();
            comando.CommandText = "Select *From Media";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listB_Nome.Items.Add(dr[0].ToString());
                    listB_Nota_1.Items.Add(dr[1].ToString());
                    listB_Nota_2.Items.Add(dr[2].ToString());
                    listB_Nota_3.Items.Add(dr[3].ToString());
                    listB_Nota_4.Items.Add(dr[4].ToString());
                    listB_Nota_5.Items.Add(dr[5].ToString());
                    listB_Nota_6.Items.Add(dr[6].ToString());
                    listB_Nota_7.Items.Add(dr[7].ToString());
                    listB_Nota_8.Items.Add(dr[8].ToString());
                }
            }
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listB_Nota_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listB_Nota_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listB_Nota_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listB_Nota_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listB_Nota_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listB_Nota_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listB_Nota_7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }
        private void listB_Nota_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listB_Nome.SelectedIndex = l.SelectedIndex;
                listB_Nota_1.SelectedIndex = l.SelectedIndex;
                listB_Nota_2.SelectedIndex = l.SelectedIndex;
                listB_Nota_3.SelectedIndex = l.SelectedIndex;
                listB_Nota_4.SelectedIndex = l.SelectedIndex;
                listB_Nota_5.SelectedIndex = l.SelectedIndex;
                listB_Nota_6.SelectedIndex = l.SelectedIndex;
                listB_Nota_7.SelectedIndex = l.SelectedIndex;
                listB_Nota_8.SelectedIndex = l.SelectedIndex;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Media_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int media;
            media = txt_resultado.ToString();
           

            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                media = (listB_Nota_1.SelectedIndex + listB_Nota_2.SelectedIndex + listB_Nota_3.SelectedIndex + listB_Nota_4.SelectedIndex
                     + listB_Nota_5.SelectedIndex + listB_Nota_6.SelectedIndex + listB_Nota_7.SelectedIndex + listB_Nota_8.SelectedIndex) /8;          
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_resultado.Clear();
        }
    }
    }
}
