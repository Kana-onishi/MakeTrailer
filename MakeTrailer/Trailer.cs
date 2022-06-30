using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeTrailer
{
    static class Trailer
    {
        private static Random random = new Random();
        //Method to make preview of the next installment
        //(formal argument)nameA, nameB, nameC
        //(return value)String of made preview of the next installment
        public static string Get(string nameA, string nameB, string nameC)
        {
            string content;

            //input contents from file
            List<string> contentsList = ContentsFileIO.Read();

            //return error message if there isn't file.
            if(contentsList == null)
            {
                return "予告ファイルがありません";
            }
            
            //return error message if there is no contents in the file
            if(contentsList.Count <= 0)
            {
                return "予告ファイルに予告がありません";
            }

            //select a contents in random
            int index = random.Next(contentsList.Count);
            content = contentsList[index];

            //overwrite with using friends name
            content = content.Replace(",", Environment.NewLine);
            content = content.Replace("[人物A]", nameA);
            content = content.Replace("[人物B]", nameB);
            content = content.Replace("[人物C]", nameC);

            return content;
        }
    }
}
