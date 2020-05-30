using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_BRINCAR
{
    public partial class frmInstrucoes : Form
    {
        public frmInstrucoes()
        {
            InitializeComponent();
        }

        public frmInstrucoes(string instrucao)
        {
            InitializeComponent();
            txtInstrucoes.Text = instrucao;
        }

        private void frmInstrucoes_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
