using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace ezhkov
{
    public static class FileWork
    {
        public static string FilePath;

        public static List<string> ReadLines()
        {
            return File.ReadAllLines(FilePath).ToList();
        }

        public static void SaveFile(List<string> ist)
        {
            File.WriteAllLines(FilePath, ist.ToArray());
        }

        public static string ReadLine(int id)
        {
            List<string> ist = ReadLines();
            string st = "";
            foreach (string s in ist)
            {
                if (s.StartsWith(id.ToString() + ";"))
                {
                    st = s;
                    break;
                }
            }
            return st;
        }

        public static DataTable ReadTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("ФИО больного");
            dt.Columns.Add("Болезнь");
            dt.Columns.Add("Когда пришел на прием");
            dt.Columns.Add("Когда выписан");
            dt.Columns.Add("Должность врача");
            dt.Columns.Add("ФИО врача");

            List<string> ist = ReadLines();
            foreach (string s in ist)
            {
                string[] ss = s.Split(';');
                dt.Rows.Add(ss[0], ss[1], ss[2], ss[3], ss[4], ss[5], ss[6]);
            }
            return dt;

        }

        public static void AddUpdate(int id, string FIObol, string Bolezn, DateTime Prishel, DateTime Ushel, string DolzVracha, string FIOvr )
        {
            List<string> ist = ReadLines();
            if (id == 0)
            {
                foreach (string s in ist)
                {
                    string[] ss = s.Split(';');
                    if (Convert.ToInt32(ss[0]) > id)
                    {
                        id = Convert.ToInt32(ss[0]);
                    }
                }
                id++;
                string st = id.ToString() + ";" + FIObol + ";" + Bolezn + ";" + Prishel + ";" + Ushel + ";" + DolzVracha + ";" + FIOvr;
                ist.Add(st);
            }
            else
            {
                for (int i = 0; i < ist.Count; i++)
                {
                    if (ist[i].StartsWith(id.ToString() + ";"))
                    {
                        ist[i] = id.ToString() + ";" + FIObol + ";" + Bolezn + ";" + Prishel + ";" + Ushel + ";" + DolzVracha + ";" + FIOvr;
                        break;
                    }
                }
            }
            SaveFile(ist);
        }
        public static void Delete(int id)
        {
            List<string> ist = ReadLines();
            string st = ReadLine(id);
            ist.Remove(st);
            SaveFile(ist);
        }
    }

}
