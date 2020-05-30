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
using System.IO;

namespace PROJETO_BRINCAR
{
    public partial class frmCadastro : Form
    {
              
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || picImg.Image == null)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                byte[] vImg = null;

                FileStream fstream = new FileStream(this.txtCaminho.Text, FileMode.Open, FileAccess.Read);
                //objeto referente a transições de dados e busca de dados por referencia de bytes, armazenamento de bytes
                BinaryReader br = new BinaryReader(fstream);

                vImg = br.ReadBytes((int)fstream.Length);

                string cSql = "insert into brincadeiras(nome, image, descricao) values (@nome, @image, @instrucao)";

                string conexao = "database=projeto_brincar; server=localhost; uid=root; pwd=1234; SSLmode=none";

                MySqlConnection oCon = new MySqlConnection(conexao);

                MySqlCommand comandoIMG = new MySqlCommand(cSql, oCon);

                MySqlDataReader drLeitor;
                // este objeto faz a leitura da sua tabela, lê todos campos e linhas e retornará para uma variável do c#  

                try
                {

                    oCon.Open();
                    comandoIMG.Parameters.Add(new MySqlParameter("@nome", txtNome.Text));

                    comandoIMG.Parameters.Add(new MySqlParameter("@image", vImg));

                    comandoIMG.Parameters.Add(new MySqlParameter("@instrucao", txtInstrucoes.Text));

                    drLeitor = comandoIMG.ExecuteReader();

                    MessageBox.Show("Brincadeira cadastrada com sucesso!");

                    if (MessageBox.Show("Deseja continuar cadastrando?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //this.Visible = false;
                        this.Close();
                        new frmCadastro().Show();

                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    oCon.Close();
                }

            }
                        
        }

        

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            picImg.Image = Bitmap.FromFile("C://Users//Daniel//Desktop//PROJETO BRINCAR//IMAGENS//semImagem.jpg");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Digite aqui o nome da brincadeira e depois clique em alterar";

        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            
        }
        
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
           
    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picImg_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png| AllFiles(*.*)|*.*";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string imagem = abrir.FileName.ToString();
                txtCaminho.Text = imagem;
                picImg.ImageLocation = imagem;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picImg_Click(object sender, EventArgs e)
        {

        }
    }
}
