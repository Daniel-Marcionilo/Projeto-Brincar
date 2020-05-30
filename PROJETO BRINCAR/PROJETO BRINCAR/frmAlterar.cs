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
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        public string nomebrincadeira = "";

        public frmAlterar(string nome)
        {
            InitializeComponent();

            string nome_vindo = ""; 

            txtNome.Text = nome;

            nome_vindo = txtNome.Text;

            nomebrincadeira = nome_vindo;
        }

        public int codigo = 0;
        private void frmAlterar_Load(object sender, EventArgs e)
        {
            string string_conexao = "database=projeto_brincar; server=localhost; uid=root; pwd=1234; SSLmode=none";

            MySqlConnection minha_conexao = new MySqlConnection(string_conexao);

            minha_conexao.Open();

            string query_consulta = "select * from brincadeiras where nome ='" + txtNome.Text + "'";
            
            MySqlCommand oComando = new MySqlCommand(query_consulta, minha_conexao);

            MySqlDataReader oLeitor;

            oLeitor = oComando.ExecuteReader();

            if(oLeitor.Read())
            {
                codigo = oLeitor.GetInt32("codBrinc");
                txtInstrucao.Text = oLeitor.GetString("descricao");

                byte[] vImagem = (byte[])(oLeitor["image"]);

                oLeitor.Close();
                if (vImagem == null)
                {
                    picImg.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(vImagem);
                    
                    picImg.Image = System.Drawing.Image.FromStream(mstream);
                     
                }

            }



        }

        private void btnEscolherImg_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            string string_conexao = "database=projeto_brincar; server=localhost; uid=root; pwd=1234; SSLmode=none";

            MySqlConnection CONEXAO = new MySqlConnection(string_conexao);

            MySqlCommand oCmd = new MySqlCommand("UPDATE brincadeiras SET nome = @nome, descricao = @desc, image = @image where codBrinc=@codigo", CONEXAO);

            byte[] vImg = null;

            FileStream fstream = new FileStream(this.txtCaminho.Text, FileMode.Open, FileAccess.Read);
            //objeto referente a transições de dados e busca de dados por referencia de bytes, armazenamento de bytes
            BinaryReader br = new BinaryReader(fstream);

            vImg = br.ReadBytes((int)fstream.Length);

            try
            {
                CONEXAO.Open();

                oCmd.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo;
                oCmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                oCmd.Parameters.Add("@image", MySqlDbType.LongBlob).Value = vImg;
                oCmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txtInstrucao.Text;
                
                if (txtNome.Text == nomebrincadeira)
                {
                    MessageBox.Show("Nome idêntico ao anterior", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    oCmd.ExecuteNonQuery();

                    MessageBox.Show("Alteração realizada com sucesso!");
                    nomebrincadeira = txtNome.Text;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                CONEXAO.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
