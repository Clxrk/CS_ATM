using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_Bankautomat
{
    class Konto
    {
        float balance;
        string temp;

        public Konto(float balance)
        {
            this.balance = balance;
        }

        public float GetBalance()
        {
            string path = @"balance.txt";
            string read = File.ReadAllText(path);
            return float.Parse(read);
        }
    }
}
