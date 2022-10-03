using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using SEN_Project.BusinessLogicLayer;

namespace SEN_Project.DataAccessLayer
{
    class FileManager
    {
        public static string PolicyDataFileName = "PolicyData.txt";

        public  static  void    SaveToFile  (PolicyData Data)
        {
            List<string> Lines = new List<string>();
            Lines.Add("{");
            Lines.Add('\t' + Data.Description);
            Lines.Add('\t' + Data.Price.ToString());
            Lines.Add('\t' + "[");
            if (Data.TreatmentsCovered!=null)
            {
                foreach (Treatment treatment in Data.TreatmentsCovered)
                {
                    Lines.Add('\t' + treatment.Description);
                }
            }
            Lines.Add('\t' + "]");
            Lines.Add("}");
            SaveToFile(Lines.ToArray(), PolicyDataFileName);
        }

        public  static  void    SaveToFile  (string Line,string FileName)
        {
            StreamWriter SW = new StreamWriter(FileName, true);
            SW.WriteLine(Line);
            SW.Close();
        }

        public  static  void    SaveToFile  (string[]   Lines,string    FileName)
        {
            foreach (string Line in Lines)
            {
                SaveToFile(Line,FileName);
            }
        }

        public static  string[]    ReadFromFile    (string FileName)
        {
            StreamReader SR = new StreamReader(FileName);
            List<string> Result = new List<string>();
            string Line = null;
            while ((Line = SR.ReadLine())!=null)
            {
                Result.Add(Line);
            }
            return Result.ToArray();
        }
    }
}
