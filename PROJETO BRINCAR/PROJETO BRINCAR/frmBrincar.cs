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
using System.Drawing.Text;
namespace PROJETO_BRINCAR
{
    public partial class frmBrincar : Form
    {
        public frmBrincar()
        {
            InitializeComponent();
        }

        public string instrucao = "";

        private void frmBrincar_Load(object sender, EventArgs e)
        {
            pcbImagem.Image = Bitmap.FromFile("C://Users//Daniel//Desktop//PROJETO BRINCAR//IMAGENS//PENSANDO.jpg");
            btnLivro.Visible = false;           
        }

        private void picX_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro form = new frmCadastro();

            form.Show();
           
        }

        private void btnBrincar_Click(object sender, EventArgs e)
        {
            btnLivro.Visible = true;
            string string_conexao = "database=projeto_brincar; server=localhost; uid=root; pwd=1234; SSLmode=none";
            //string de conexao com o banco de dados.
            
            MySqlConnection conexao = new MySqlConnection(string_conexao);
            //Declarando uma instância da classe MySqlConnection e passando
            //como parâmetro minha variável de conexão
            //para realizarmos a conexão ao nosso banco de dados 

            string query_sql = "SELECT * FROM brincadeiras ORDER BY RAND() LIMIT 1";
            //declarando uma variável do tipo string que RANDOMIZA UMA COLUNA E TRAZ SOMENTE UM REGISTRO, NO CASO, UMA BRINCADEIRA
            
            MySqlCommand ocmd = new MySqlCommand(query_sql, conexao);
            //declarando uma instância da classe MySqlCommand que tem como parâmetro
            //minha varíavel que realiza uma consulta randomizada e minha conexao ao banco
            MySqlDataReader drLeitor; 
            //Declarando uma variável que será uma instância da classe MySqlDataReader
            //que vai ler e buscar dados da tabela do nosso banco
            
            try
            {
                conexao.Open();
                //aqui utilizamos um try para tentar abrir a conexao com o banco 
                
                drLeitor = ocmd.ExecuteReader();
                //em seguida executamos nossa variável de comando que realizará a
                //consulta randomizada, o valor trazido será armazenado na minha varíavel
                //drLeitor

                while(drLeitor.Read()) //Enquanto conseguir ler dados da tabela, irá 
                {
                    string nome = drLeitor.GetString("nome");
                    //declarar uma variável do tipo string, que receberá o nome trazido da
                    //minha tabela
                    
                    lblBrincadeira.Text = nome.ToString();
                    //trazido o nome, jogo esse nome na minha label, que exibirá esse nome

                    instrucao = drLeitor.GetString("descricao");

                    byte[] vImagem = (byte[])(drLeitor["image"]);
                    //também trarei a imagem que armazenada no banco e armazenarei essa img
                    //na minha variável do tipo byte

                    if(vImagem == null)
                    {
                        pcbImagem.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(vImagem);
                        //objeto responsável por guardar determinadas quantidades de bytes

                        pcbImagem.Image = System.Drawing.Image.FromStream(mstream);
                        //quero que o sistema desenhe na picturebox   
                    }
                    
                }
                drLeitor.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conexao.Close();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBrincadeiras frmBrincar = new frmBrincadeiras();
            frmBrincar.Show();

        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            frmInstrucoes frm = new frmInstrucoes(instrucao);
            frm.Show();
        }
    }
}
