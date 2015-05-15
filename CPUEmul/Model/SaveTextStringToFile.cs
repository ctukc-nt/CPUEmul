using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPUEmul.Model
{
    class SaveTextStringToFile
    {
        public void WriteStringToFile(string path, string content)
        {
            StreamWriter f = new StreamWriter(path);
            f.Write(content);
            f.Close();
        }
    }
}
