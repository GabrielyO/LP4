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
    public partial class FormCadastrarLivro : Form
    {
        public FormCadastrarLivro()
        {
            InitializeComponent();
        }

        

        private void btnEnviarCadastro_Click(object sender, EventArgs e)
        {
            //Conexão que cadastra livro
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=biblioteca;Uid=root;Pwd="),
                CommandText = "INSERT INTO livro (Título, Autor, Editora) VALUES (@titulo, @autor, @editora);"
            };

            //Conexão que verifica se a Textbox está vazia
            MySqlCommand cmd2 = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=biblioteca;Uid=root;Pwd="),
                CommandText = "SELECT l.Título, l.Autor, l.Editora FROM livro l;"
            };

            //Verificação
            cmd2.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd2.ExecuteReader();
            cmd2.Connection.Close();

            bool leu = false;

            if (resultado.HasRows)
            {
                resultado.Read();
                Livro l = new Livro();
                l.titulo = resultado.GetString(0);
                l.autor = resultado.GetString(1);
                l.editora = resultado.GetString(2);

                cmd.Parameters.AddWithValue("@titulo", l.titulo);
                cmd.Parameters.AddWithValue("@autor", l.autor);
                cmd.Parameters.AddWithValue("@editora", l.editora);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                MessageBox.Show("Livro cadastrado com sucesso");                
            }

            else MessageBox.Show("Preencha todos os campos corretamente");            
        }

        public void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
