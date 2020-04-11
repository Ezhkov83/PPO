using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezhkov
{
    class BolBol
    {
        public int id;
        public string FIObol;
        public string Bolezn;
        public DateTime Prishel;
        public DateTime Ushel;
        public string DolzVracha;
        public string FIOvr;

        public BolBol()
        {

        }

        public BolBol(int _id)
        {
            string st = FileWork.ReadLine(_id);
            string[] ss = st.Split(';');
            id = Convert.ToInt32(ss[0]);
            FIObol = ss[1];
            Bolezn = ss[2];
            Prishel = Convert.ToDateTime(ss[3]);
            Ushel = Convert.ToDateTime(ss[4]);
            DolzVracha = ss[5];
            FIOvr = ss[6];
        }
        public void Save()
        {
            FileWork.AddUpdate(id, FIObol, Bolezn, Prishel, Ushel, DolzVracha, FIOvr);
        }
    }
}
