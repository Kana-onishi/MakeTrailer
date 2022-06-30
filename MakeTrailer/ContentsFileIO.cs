using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MakeTrailer
{
    static class ContentsFileIO
    {
        //File and Dir where save preview of the next installment
        private const string DirName = "Data";
        private const string FileName = DirName + "\\contents.csv";

        //Method to load contents
        //(return value) the List stores the contents
        public static List<string> Read()
        {
            List<string> list = new List<string>();
            //If there isn't file, return null
            if(File.Exists(FileName) == false)
            {
                return null;
            }

            //load file of the contents
            try
            {
                using (StreamReader reader = new StreamReader(FileName, Encoding.Default))
                {
                    //read each line
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }return list;
            }catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }
        }

        //Method to write contents of the preview of the next installment
        //(return value) list: the contents to wirte on the file
        public static void Write(List<string> List)
        {
            //Make dir if there is no dir
            if(Directory.Exists(DirName) == false)
            {
                Directory.CreateDirectory(DirName);
            }

            //Write the contents
            try
            {
                using(StreamWriter writer = new StreamWriter(FileName, false, Encoding.Default))
                {
                    foreach (string s in List)
                    {
                        writer.Write(s);
                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
