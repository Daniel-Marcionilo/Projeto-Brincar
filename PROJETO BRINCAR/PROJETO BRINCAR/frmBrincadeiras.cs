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
namespace PROJETO_BRINCAR
{
    public partial class frmBrincadeiras : Form
    {
        public frmBrincadeiras()
        {
            InitializeComponent();
        }

        private void frmBrincadeiras_Load(object sender, EventArgs e)
        {
            fnRefresh();
        }
        public void fnRefresh()
        {
            MySqlDataAdapter select = new MySqlDataAdapter("SELECT nome as NOME FROM BRINCADEIRAS order by nome asc", Program.conexao);
            DataTable dados = new DataTable();

            select.Fill(dados);
            grdBrincadeiras.DataSource = dados;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAlterar alt = new frmAlterar(grdBrincadeiras.CurrentRow.Cells[0].Value.ToString());
                    
            alt.Show();
 /*
            if (txtPesquisa.Text == "")
                {
                    txtPesquisa.Text = "Digite aqui o novo nome";
                    MessageBox.Show("Para editar o nome da brincadeira, selecione a brincadeira que desejar, digite um novo nome na caixa de texto e clique no lápis.");
                }
                else if(MessageBox.Show("Deseja realmente alterar a brincadeira para "+txtPesquisa.Text, "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)  
                {
                        string string_conexao = "database=projeto_brincar; server=localhost; uid=root; pwd=1234; SSLmode=none";

                        MySqlConnection CONEXAO = new MySqlConnection(string_conexao);

                        string consulta = "select * from brincadeiras where nome ='" + grdBrincadeiras.CurrentRow.Cells[0].Value.ToString() + "'";

                        MySqlCommand cmdConsulta = new MySqlCommand(consulta, CONEXAO);

                        MySqlCommand oCmd = new MySqlCommand("UPDATE brincadeiras SET nome = @nome where codBrinc=@codigo", CONEXAO);

                        MySqlDataReader data_R_Consulta;


                        try
                        {
                            CONEXAO.Open();

                            data_R_Consulta = cmdConsulta.ExecuteReader();

                            int resultadoConsulta = 0;

                            if (data_R_Consulta.Read())
                            {
                                resultadoConsulta = data_R_Consulta.GetInt16("codBrinc");
                                data_R_Consulta.Close();
                                oCmd.Parameters.Add("@codigo", MySqlDbType.Int32).Value = resultadoConsulta;
                                oCmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtPesquisa.Text;

                                oCmd.ExecuteNonQuery();

                                MessageBox.Show("Alteração realizada com sucesso!");
                                fnRefresh();
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
                 }               */ 
                    
            }
        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter oTab = new MySqlDataAdapter("SELECT nome from brincadeiras WHERE NOME LIKE '" + txtPesquisa.Text + "%'", Program.conexao);
            DataTable oDados = new DataTable();

            oTab.Fill(oDados);
            grdBrincadeiras.DataSource = oDados;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            fnRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string string_conexao = "database=projeto_brincar; server=localhost; uid=root; pwd=1234; SSLmode=none";

            MySqlConnection CONEXAO = new MySqlConnection(string_conexao);

            MySqlCommand oCmd = new MySqlCommand("Delete from brincadeiras where codBrinc = @codigo", CONEXAO);

            string consulta = "select * from brincadeiras where nome ='" + grdBrincadeiras.CurrentRow.Cells[0].Value.ToString() + "'";
            
            MySqlCommand cmdConsulta = new MySqlCommand(consulta, CONEXAO);

            MySqlDataReader data_R_Consulta;

            if (MessageBox.Show("Deseja realmente excluir esta brincadeira?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    CONEXAO.Open();

                    data_R_Consulta = cmdConsulta.ExecuteReader();

                    int resultadoConsulta = 0;

                    if (data_R_Consulta.Read())
                    {
                        resultadoConsulta = data_R_Consulta.GetInt16("codBrinc");
                        data_R_Consulta.Close();
                        oCmd.Parameters.Add("@codigo", MySqlDbType.Int32).Value = resultadoConsulta;

                        oCmd.ExecuteNonQuery();

                        MessageBox.Show("Exclusão realizada com sucesso!");
                        fnRefresh();
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

        }

        private void txtPesquisa_DragEnter(object sender, DragEventArgs e)
        {
                       
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
                                  
        }

        private void txtPesquisa_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MySqlDataAdapter oTab = new MySqlDataAdapter("SELECT nome from brincadeiras WHERE NOME LIKE '" + txtPesquisa.Text + "%'", Program.conexao);
                DataTable oDados = new DataTable();

                oTab.Fill(oDados);
                grdBrincadeiras.DataSource = oDados;
            }
           
        }
    }
}
