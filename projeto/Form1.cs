using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class Lista_de_Contactos : Form
    {
        private string ficheiro = "";
        private List<Contactos> contactos = new List<Contactos>();

        public Lista_de_Contactos()
        {
            InitializeComponent();

        }

        private void Lista_de_Contactos_Load(object sender, EventArgs e)
        {
             
        }
        public class Contactos
        {
            public string nome { get; set; }
            public string telemóvel { get; set; }
            public string email { get; set; }
            public string endereco { get; set; }
            public string urgencia { get; set; }
                
               public override string ToString()
            {
                return $"{nome}, {telemóvel}, {email}, {endereco}, {urgencia}";
            }
            

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            Contactos contacto = new Contactos
            {
                nome = textBox1.Text,
                telemóvel = textBox2.Text,
                email = textBox3.Text,
                endereco = textBox4.Text,
                urgencia = textBox5.Text,
            };
            contactos.Add(contacto);
                
            lista.Items.Add(contacto);
            Limpar();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if(lista.SelectedIndex != -1)
            {
                contactos[lista.SelectedIndex].nome = textBox1.Text;
                contactos[lista.SelectedIndex].telemóvel = textBox2.Text;
                contactos[lista.SelectedIndex].email = textBox3.Text;
                contactos[lista.SelectedIndex].endereco = textBox4.Text;
                contactos[lista.SelectedIndex].urgencia = textBox5.Text;


            }
            else
            {
                MessageBox.Show("Não indicou qual é o nome da lista para editar", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Abrir_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Ficheiro RTF| *.rtf | Ficheiros TXT| *.txt | Todos | *.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ficheiro = openFileDialog1.FileName;
                lista.Text = ficheiro; 
            }
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog salvarDialogo = new SaveFileDialog();
                salvarDialogo.Filter = "Ficheiro RTF| *.rtf | Ficheiros TXT| *.txt | Todos | *.*";
                salvarDialogo.Title = "Guardar contactos";

                if (salvarDialogo.ShowDialog() == DialogResult.OK)
                {
                    string file = salvarDialogo.FileName;
                    GuardarContactosnumFicheiro(file);
                    MessageBox.Show("Contatos guardados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar contactos: {ex.Message}");
            }

        }
        private void GuardarContactosnumFicheiro(string nomeArquivo)
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                foreach (Contactos contactos in contactos)
                {
                    writer.WriteLine($"{contactos.nome}, {contactos.telemóvel}, {contactos.email}, {contactos.endereco}, {contactos.urgencia}");
                }
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpar()
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox1.Focus();
        }
  
    }
           
}

        
