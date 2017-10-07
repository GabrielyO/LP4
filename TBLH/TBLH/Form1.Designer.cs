namespace TBLH
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.relogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarCorrida = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarParar.Location = new System.Drawing.Point(56, 171);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(141, 36);
            this.btnIniciarParar.TabIndex = 0;
            this.btnIniciarParar.Text = "Iniciar";
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // relogio
            // 
            this.relogio.AutoSize = true;
            this.relogio.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relogio.Location = new System.Drawing.Point(12, 110);
            this.relogio.Name = "relogio";
            this.relogio.Size = new System.Drawing.Size(228, 58);
            this.relogio.TabIndex = 2;
            this.relogio.Text = "00:00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(56, 213);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 38);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar Tempo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(56, 257);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(141, 38);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar Tempo";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(72, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 26);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Tipos de Corrida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "1 - Asfalto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "2 - Terra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "3 - Grama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "4 - Areia";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvarCorrida);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(246, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 399);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(65, 188);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(32, 31);
            this.txtTipo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(65, 230);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(209, 26);
            this.dateTimePicker.TabIndex = 13;
            // 
            // btnSalvarCorrida
            // 
            this.btnSalvarCorrida.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCorrida.Location = new System.Drawing.Point(77, 288);
            this.btnSalvarCorrida.Name = "btnSalvarCorrida";
            this.btnSalvarCorrida.Size = new System.Drawing.Size(177, 38);
            this.btnSalvarCorrida.TabIndex = 14;
            this.btnSalvarCorrida.Text = "Salvar Corrida";
            this.btnSalvarCorrida.UseVisualStyleBackColor = true;
            this.btnSalvarCorrida.Click += new System.EventHandler(this.btnSalvarCorrida_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.Location = new System.Drawing.Point(678, 23);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(177, 38);
            this.btnExibir.TabIndex = 15;
            this.btnExibir.Text = "Exibir Corridas";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(557, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(37, 342);
            this.listBox1.TabIndex = 16;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(600, 67);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(141, 342);
            this.listBox2.TabIndex = 17;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(747, 67);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(126, 342);
            this.listBox3.TabIndex = 18;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(879, 67);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(83, 342);
            this.listBox4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 423);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.relogio);
            this.Controls.Add(this.btnIniciarParar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.Label relogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSalvarCorrida;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
    }
}

