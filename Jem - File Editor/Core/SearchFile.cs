using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jem___File_Editor.Core
{
    class SearchFile
    {
        public string _nameFile;
        public int _count = 0;
        private DateTime _timeFile = new DateTime();
        private string _directory;

       
        public SearchFile(string directory) {

            this._directory = directory;

        }

        public string SearchFileName()
        {
            
            DirectoryInfo Dir = new DirectoryInfo(_directory);
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            
            foreach (FileInfo File in Files)
            {

                if (_count == 0)
                {
                    _timeFile = File.CreationTime;
                    _nameFile = File.FullName;
                }
                else {
                    if (_timeFile > File.CreationTime)
                    {

                    }
                    else {
                        _nameFile = File.FullName;
                    }
                }
                _count += 1;
                
            }
            return _nameFile;

        }
}
}
