using System;
using System.IO;

namespace CPUEmul.Model
{
    public class LoadTextStringFromFile
    {
        public string ReadTextFileToEnd(string path)
        {
            StreamReader f = new StreamReader(path);
            String text = f.ReadToEnd();
            f.Close();

            return text;
        }
    }

}