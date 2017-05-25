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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Título = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Editora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBoxTitulo = new System.Windows.Forms.CheckBox();
            this.checkBoxAutor = new System.Windows.Forms.CheckBox();
            this.checkBoxEditora = new System.Windows.Forms.CheckBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnFazerConsulta = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Código,
            this.Título,
            this.Autor,
            this.Editora});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 357);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Código
            // 
            this.Código.Text = "Código";
            this.Código.Width = 52;
            // 
            // Título
            // 
            this.Título.Text = "Título";
            this.Título.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Título.Width = 238;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Autor.Width = 235;
            // 
            // Editora
            // 
            this.Editora.Text = "Editora";
            this.Editora.Width = 445;
            // 
            // checkBoxTitulo
            // 
            this.checkBoxTitulo.AutoSize = true;
            this.checkBoxTitulo.Location = new System.Drawing.Point(96, 21);
            this.checkBoxTitulo.Name = "checkBoxTitulo";
            this.checkBoxTitulo.Size = new System.Drawing.Size(54, 17);
            this.checkBoxTitulo.TabIndex = 1;
            this.checkBoxTitulo.Text = "Título";
            this.checkBoxTitulo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutor
            // 
            this.checkBoxAutor.AutoSize = true;
            this.checkBoxAutor.Location = new System.Drawing.Point(96, 44);
            this.checkBoxAutor.Name = "checkBoxAutor";
            this.checkBoxAutor.Size = new System.Drawing.Size(51, 17);
            this.checkBoxAutor.TabIndex = 2;
            this.checkBoxAutor.Text = "Autor";
            this.checkBoxAutor.UseVisualStyleBackColor = true;
            // 
            // checkBoxEditora
            // 
            this.checkBoxEditora.AutoSize = true;
            this.checkBoxEditora.Location = new System.Drawing.Point(96, 67);
            this.checkBoxEditora.Name = "checkBoxEditora";
            this.checkBoxEditora.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEditora.TabIndex = 3;
            this.checkBoxEditora.Text = "Editora";
            this.checkBoxEditora.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(177, 19);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(318, 20);
            this.txtConsulta.TabIndex = 4;
            // 
            // btnFazerConsulta
            // 
            this.btnFazerConsulta.Location = new System.Drawing.Point(294, 45);
            this.btnFazerConsulta.Name = "btnFazerConsulta";
            this.btnFazerConsulta.Size = new System.Drawing.Size(80, 26);
            this.btnFazerConsulta.TabIndex = 5;
            this.btnFazerConsulta.Text = "Consultar";
            this.btnFazerConsulta.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(522, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(70, 41);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 465);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFazerConsulta);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.checkBoxEditora);
            this.Controls.Add(this.checkBoxAutor);
            this.Controls.Add(this.checkBoxTitulo);
            this.Controls.Add(this.listView1);
            this.Name = "FormConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Código;
        private System.Windows.Forms.ColumnHeader Título;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Editora;
        private System.Windows.Forms.CheckBox checkBoxTitulo;
        private System.Windows.Forms.CheckBox checkBoxAutor;
        private System.Windows.Forms.CheckBox checkBoxEditora;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnFazerConsulta;
        private System.Windows.Forms.Button btnVoltar;
    }
}