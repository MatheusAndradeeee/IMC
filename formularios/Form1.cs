using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularios
{   
    public partial class Form1 : Form
    {
        List<Usuario> ListU = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
            tx_incorreto.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;

            string cpf = tx_cpf.Text;

            string senha = tx_senha.Text;

            string con_senha = tx_conf_senha.Text;
                
           

            if(senha == con_senha)
            {
                Usuario usuario = new Usuario();
                usuario.SetNome(tx_nome.Text);
                usuario.SetCpf(tx_cpf.Text);
                usuario.SetSexo(tx_sexo.Text);
                usuario.SetSenha(tx_senha.Text);
                
                MessageBox.Show("Senha confirmada");
            }
            else 
            {
                tx_incorreto.Text = "Senhas diferentes";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Text = "";
            tx_cpf.Text = "";
            tx_senha.Text = "";
            tx_conf_senha.Text = "";
            

        }

        private void tx_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_conf_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
