using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoBiblioteca
{
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
        }

        //Método que preenche a lista.
        private void PreencherListView(List<Livro> LIVROS) {
            ListViewItem item;
            foreach (Livro LIVRO in LIVROS)
            {
                item = new ListViewItem(LIVRO.id.ToString());
                item.SubItems.Add(LIVRO.titulo);
                item.SubItems.Add(LIVRO.autor);
                item.SubItems.Add(LIVRO.editora);
                LISTA.Items.Add(item);
            }
            txtConsulta.Clear();
            radiotitulo.Checked = false;
            radioautor.Checked = false;
            radioeditora.Checked = false;
        }

        //Volta para a MainWindows.
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnFazerConsulta_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=biblioteca;Uid=root;Pwd=")
            };

            //Faço as consultas de acordo com os radios.
            if(radiotitulo.Checked && txtConsulta.Text != string.Empty)
            {
                cmd.CommandText = "SELECT * FROM livro l WHERE Título LIKE (@titulo)";
                cmd.Parameters.AddWithValue("@titulo", txtConsulta.Text + "%");
                LISTA.Items.Clear();
                cmd.Connection.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();

                List<Livro> LIVROS = new List<Livro>();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Livro L = new Livro();
                        L.id = r.GetInt32(0);
                        L.titulo = r.GetString(1);
                        L.autor = r.GetString(2);
                        L.editora = r.GetString(3);
                        LIVROS.Add(L);
                    }
                }

                PreencherListView(LIVROS);
                cmd.Connection.Close();
            }
            else if (radioautor.Checked && txtConsulta.Text != string.Empty)
            {
                cmd.CommandText = "SELECT * FROM livro l WHERE Autor LIKE (@autor)";
                cmd.Parameters.AddWithValue("@autor", txtConsulta.Text + "%");
                LISTA.Items.Clear();
                cmd.Connection.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();

                List<Livro> LIVROS = new List<Livro>();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Livro L = new Livro();
                        L.id = r.GetInt32(0);
                        L.titulo = r.GetString(1);
                        L.autor = r.GetString(2);
                        L.editora = r.GetString(3);
                        LIVROS.Add(L);
                    }
                }

                PreencherListView(LIVROS);
                cmd.Connection.Close();
            }
            else if (radioeditora.Checked && txtConsulta.Text != string.Empty)
            {
                cmd.CommandText = "SELECT * FROM livro l WHERE Editora LIKE (@editora)";
                cmd.Parameters.AddWithValue("@editora", txtConsulta.Text + "%");
                LISTA.Items.Clear();
                cmd.Connection.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();

                List<Livro> LIVROS = new List<Livro>();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Livro L = new Livro();
                        L.id = r.GetInt32(0);
                        L.titulo = r.GetString(1);
                        L.autor = r.GetString(2);
                        L.editora = r.GetString(3);
                        LIVROS.Add(L);
                    }
                }

                PreencherListView(LIVROS);
                cmd.Connection.Close();
            }
            else if (txtConsulta.Text == string.Empty)
            {
                cmd.CommandText = "SELECT * FROM livro l ORDER BY l.Título ASC;";
                LISTA.Items.Clear();
                cmd.Connection.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();

                List<Livro> LIVROS = new List<Livro>();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Livro L = new Livro();
                        L.id = r.GetInt32(0);
                        L.titulo = r.GetString(1);
                        L.autor = r.GetString(2);
                        L.editora = r.GetString(3);
                        LIVROS.Add(L);
                    }
                }

                PreencherListView(LIVROS);
                cmd.Connection.Close();
            }
        }
    }
}
