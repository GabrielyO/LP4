namespace TrabalhoBiblioteca
{
    partial class FormConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnFazerConsulta = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.radiotitulo = new System.Windows.Forms.RadioButton();
            this.radioautor = new System.Windows.Forms.RadioButton();
            this.radioeditora = new System.Windows.Forms.RadioButton();
            this.filtro = new System.Windows.Forms.GroupBox();
            this.LISTA = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TÍTULO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AUTOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EDITORA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnID = new System.Windows.Forms.Button();
            this.btnTITULO = new System.Windows.Forms.Button();
            this.filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(385, 37);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(554, 29);
            this.txtConsulta.TabIndex = 4;
            // 
            // btnFazerConsulta
            // 
            this.btnFazerConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFazerConsulta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFazerConsulta.FlatAppearance.BorderSize = 5;
            this.btnFazerConsulta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFazerConsulta.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerConsulta.Location = new System.Drawing.Point(526, 72);
            this.btnFazerConsulta.Name = "btnFazerConsulta";
            this.btnFazerConsulta.Size = new System.Drawing.Size(263, 36);
            this.btnFazerConsulta.TabIndex = 5;
            this.btnFazerConsulta.Text = "Consultar";
            this.btnFazerConsulta.UseVisualStyleBackColor = true;
            this.btnFazerConsulta.Click += new System.EventHandler(this.btnFazerConsulta_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatAppearance.BorderSize = 5;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVoltar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(994, 28);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 51);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // radiotitulo
            // 
            this.radiotitulo.AutoSize = true;
            this.radiotitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radiotitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiotitulo.Location = new System.Drawing.Point(65, 25);
            this.radiotitulo.Name = "radiotitulo";
            this.radiotitulo.Size = new System.Drawing.Size(88, 26);
            this.radiotitulo.TabIndex = 7;
            this.radiotitulo.TabStop = true;
            this.radiotitulo.Text = "TÍTULO";
            this.radiotitulo.UseVisualStyleBackColor = true;
            // 
            // radioautor
            // 
            this.radioautor.AutoSize = true;
            this.radioautor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioautor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioautor.Location = new System.Drawing.Point(65, 54);
            this.radioautor.Name = "radioautor";
            this.radioautor.Size = new System.Drawing.Size(87, 26);
            this.radioautor.TabIndex = 8;
            this.radioautor.TabStop = true;
            this.radioautor.Text = "AUTOR";
            this.radioautor.UseVisualStyleBackColor = true;
            // 
            // radioeditora
            // 
            this.radioeditora.AutoSize = true;
            this.radioeditora.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioeditora.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioeditora.Location = new System.Drawing.Point(65, 80);
            this.radioeditora.Name = "radioeditora";
            this.radioeditora.Size = new System.Drawing.Size(102, 26);
            this.radioeditora.TabIndex = 9;
            this.radioeditora.TabStop = true;
            this.radioeditora.Text = "EDITORA";
            this.radioeditora.UseVisualStyleBackColor = true;
            // 
            // filtro
            // 
            this.filtro.Controls.Add(this.radiotitulo);
            this.filtro.Controls.Add(this.radioeditora);
            this.filtro.Controls.Add(this.radioautor);
            this.filtro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filtro.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro.Location = new System.Drawing.Point(178, 3);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(167, 111);
            this.filtro.TabIndex = 10;
            this.filtro.TabStop = false;
            this.filtro.Text = "FILTRAR";
            // 
            // LISTA
            // 
            this.LISTA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LISTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LISTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LISTA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TÍTULO,
            this.AUTOR,
            this.EDITORA});
            this.LISTA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISTA.GridLines = true;
            this.LISTA.Location = new System.Drawing.Point(31, 120);
            this.LISTA.MultiSelect = false;
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(1319, 315);
            this.LISTA.TabIndex = 11;
            this.LISTA.UseCompatibleStateImageBehavior = false;
            this.LISTA.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 69;
            // 
            // TÍTULO
            // 
            this.TÍTULO.Text = "TÍTULO";
            this.TÍTULO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TÍTULO.Width = 577;
            // 
            // AUTOR
            // 
            this.AUTOR.Text = "AUTOR";
            this.AUTOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AUTOR.Width = 367;
            // 
            // EDITORA
            // 
            this.EDITORA.Text = "EDITORA";
            this.EDITORA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EDITORA.Width = 303;
            // 
            // btnID
            // 
            this.btnID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnID.FlatAppearance.BorderSize = 5;
            this.btnID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.Location = new System.Drawing.Point(31, 12);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(141, 38);
            this.btnID.TabIndex = 13;
            this.btnID.Text = "Tudo por ID";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnTITULO
            // 
            this.btnTITULO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTITULO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTITULO.FlatAppearance.BorderSize = 5;
            this.btnTITULO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTITULO.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTITULO.Location = new System.Drawing.Point(31, 50);
            this.btnTITULO.Name = "btnTITULO";
            this.btnTITULO.Size = new System.Drawing.Size(141, 38);
            this.btnTITULO.TabIndex = 14;
            this.btnTITULO.Text = "Tudo por TÍTULO";
            this.btnTITULO.UseVisualStyleBackColor = true;
            this.btnTITULO.Click += new System.EventHandler(this.btnTITULO_Click);
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1362, 463);
            this.Controls.Add(this.btnTITULO);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.LISTA);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFazerConsulta);
            this.Controls.Add(this.txtConsulta);
            this.Name = "FormConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.filtro.ResumeLayout(false);
            this.filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnFazerConsulta;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton radiotitulo;
        private System.Windows.Forms.RadioButton radioautor;
        private System.Windows.Forms.RadioButton radioeditora;
        private System.Windows.Forms.GroupBox filtro;
        private System.Windows.Forms.ListView LISTA;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TÍTULO;
        private System.Windows.Forms.ColumnHeader AUTOR;
        private System.Windows.Forms.ColumnHeader EDITORA;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnTITULO;
    }
}