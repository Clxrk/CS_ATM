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

        public Konto(float balance)                                     // Overloaded Constructor to set balance to 0
        {
            this.balance = balance;
        }

        public string GetFilePath(string file)                          // Overloaded Method to get the file / path
        {
            const string path = @"";                                    // Const var of the path
            return Path.Combine(path, file);                            // C:\Debug\1111.txt
        }

        public string GetBalance(string path)                           // Overloaded Method to read the balance of the file
        {
            string read = File.ReadAllText(path);                       // Reads the file 1111.txt
            return read;                                                // Returns content
        }
    }
}
