namespace projeto
{
    partial class Lista_de_Contactos
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Abrir = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.ListaTelefonica = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Telemovel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Urgência = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.Button();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Abrir
            // 
            this.Abrir.Location = new System.Drawing.Point(43, 627);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(101, 47);
            this.Abrir.TabIndex = 3;
            this.Abrir.Text = "Abrir";
            this.Abrir.UseVisualStyleBackColor = true;
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(183, 563);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(101, 47);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // ListaTelefonica
            // 
            this.ListaTelefonica.AutoSize = true;
            this.ListaTelefonica.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaTelefonica.Location = new System.Drawing.Point(78, 37);
            this.ListaTelefonica.Name = "ListaTelefonica";
            this.ListaTelefonica.Size = new System.Drawing.Size(167, 24);
            this.ListaTelefonica.TabIndex = 5;
            this.ListaTelefonica.Text = "Lista Telefónica";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(48, 99);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(70, 22);
            this.Nome.TabIndex = 6;
            this.Nome.Text = "Nome:";
            // 
            // lista
            // 
            this.lista.Dock = System.Windows.Forms.DockStyle.Right;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(331, 0);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(453, 719);
            this.lista.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(52, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(52, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(52, 296);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 20);
            this.textBox3.TabIndex = 10;
            // 
            // Telemovel
            // 
            this.Telemovel.AutoSize = true;
            this.Telemovel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telemovel.Location = new System.Drawing.Point(49, 180);
            this.Telemovel.Name = "Telemovel";
            this.Telemovel.Size = new System.Drawing.Size(112, 22);
            this.Telemovel.TabIndex = 11;
            this.Telemovel.Text = "Telemóvel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Endereço:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(52, 377);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(52, 471);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(241, 20);
            this.textBox5.TabIndex = 15;
            // 
            // Urgência
            // 
            this.Urgência.AutoSize = true;
            this.Urgência.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urgência.Location = new System.Drawing.Point(52, 429);
            this.Urgência.Name = "Urgência";
            this.Urgência.Size = new System.Drawing.Size(246, 22);
            this.Urgência.TabIndex = 16;
            this.Urgência.Text = "Contacto para urgências:";
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(183, 627);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(101, 47);
            this.Sair.TabIndex = 17;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(117, 510);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(101, 47);
            this.Adicionar.TabIndex = 18;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(43, 563);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(101, 47);
            this.Editar.TabIndex = 19;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Lista_de_Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Urgência);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Telemovel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ListaTelefonica);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Abrir);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Lista_de_Contactos";
            this.Text = "Lista de Contactos";
            this.Load += new System.EventHandler(this.Lista_de_Contactos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Abrir;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label ListaTelefonica;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Telemovel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Urgência;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Editar;
    }
}

