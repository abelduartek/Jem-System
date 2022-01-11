using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jem___File_Editor.Core
{
    class ExtractPDF
    {
        public string ExtrairTexto_PDF(string caminho)
        {
            if (!String.IsNullOrEmpty(caminho))
            {
                using (PdfReader leitor = new PdfReader(caminho))
                {
                    StringBuilder texto = new StringBuilder();

                    for (int i = 1; i <= leitor.NumberOfPages; i++)
                    {
                        texto.Append(PdfTextExtractor.GetTextFromPage(leitor, i));
                    }
                    return texto.ToString();
                }
            }
            else {

                MessageBox.Show("Não foi possível realizar a conversão! Verificar se o arquivo PDF existe");
                return "";
            }
        }
    }
}
