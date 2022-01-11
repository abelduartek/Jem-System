using Jem___File_Editor.Core;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jem___File_Editor
{
    public partial class frmTelaReadPDF : Form
    {
        public frmTelaReadPDF()
        {
            InitializeComponent();
        }


        private void frmTelaReadPDF_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string caminho = @"C:\Anexo E-mail";

            SearchFile searchFile = new SearchFile(caminho);

            try
            {
                ExtractPDF pdftxt = new ExtractPDF();
                File.AppendAllText(@"C:\Text PDF\textPDF.txt", pdftxt.ExtrairTexto_PDF(searchFile.SearchFileName()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a conversão! Verificar se o arquivo PDF existe");
            }

        }
    }
}
