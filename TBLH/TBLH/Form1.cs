using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TBLH
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 0;
        public string tempo;
        Dictionary<int, Corrida> corridas = new Dictionary<int, Corrida>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                TimeSpan ts = stopWatch.Elapsed;
                this.relogio.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();                
                btnIniciarParar.Visible = false;
                btnSalvar.Visible = true;
                btnReiniciar.Visible = true;
            }
            else
            {
                stopWatch.Start();
                btnIniciarParar.Text = "Parar";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tempo = relogio.Text;
            panel1.Visible = true;
            btnSalvarCorrida.Visible = true;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btnReiniciar.Visible = false;
            btnSalvar.Visible = false;
            relogio.Text = "00:00:00:00";
            stopWatch.Reset();
            stopWatch.Start();
            btnIniciarParar.Text = "Parar";
            btnIniciarParar.Visible = true;
        }

        private void btnSalvarCorrida_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtTipo.Text) > 4)
                    txtTipo.Text = "a";
                Corrida c = new Corrida();
                c.Data = dateTimePicker.Value;
                c.Tipo = (TipoCorrida)int.Parse(txtTipo.Text);
                c.Tempo = tempo;
                corridas.Add(i, c);
                i++;
                MessageBox.Show("Salvo");
                panel1.Visible = false;
                relogio.Text = "00:00:00:00";
                stopWatch.Reset();
                btnIniciarParar.Text = "Iniciar";
                btnReiniciar.Visible = false;
                btnSalvar.Visible = false;
                btnIniciarParar.Visible = true;
            }
            catch
            {
                txtTipo.Text = "";
                MessageBox.Show("Digite um número!");                
            }
            
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            foreach (KeyValuePair<int, Corrida> a in corridas)
            {
                listBox1.Items.Add(a.Key);
                listBox2.Items.Add(a.Value.Data);
                listBox3.Items.Add(a.Value.Tempo);
                listBox4.Items.Add(a.Value.Tipo);
            }
        }
    }
}
