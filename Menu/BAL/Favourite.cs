using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Menu.BAL
{
    class Favourite
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public Favourite(string fileName, string path)
        {
            FileName = fileName;
            Path = path;
        }
    }
}
