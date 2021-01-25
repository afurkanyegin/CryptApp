using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vigenere
    {
        internal static string vigenerecrypt(string plaintext, string key)
        {
            List<int> plainlist = new List<int>();
            List<int> keylist = new List<int>();

            string alfabe = "!'^+%&/()=?_;:<>|.,£#$½{[]}-~` abcçdefgğhıijklmnoöprsştuüvyzwxqé§╚æ■ñø@¢¤¥¦©ª¬®¯°±²³µ¶¹º¼¾ÆÐÞßþûð₿ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZQWX1234567890";
            int alfabesıra1 = 0;
            int alfabesıra2 = 0;
            
            foreach (char p in plaintext)
            {
                foreach (char a in alfabe)
                { 
                    if(p == a)
                    {
                        plainlist.Add(alfabesıra1);
                    }
                  alfabesıra1++;
                }
              alfabesıra1 = 0;
            }

            foreach (char p in key)
            {
                foreach (char a in alfabe)
                {
                    if (p == a)
                    {
                        keylist.Add(alfabesıra2);
                    }
                 alfabesıra2++;
                }
              alfabesıra2 = 0;
            }   

            StringBuilder cipherlist3 = new StringBuilder();

            for (int i = 0; i < plainlist.Count; i++)
            {
                cipherlist3.Append(alfabe[((plainlist[i] + keylist[i % keylist.Count]) % 140)]);
            }

            string cipher2 = cipherlist3.ToString();
            return cipher2;
        }

        internal static string vigeneredecrypt(string ciphertext, string key)
        {
            List<int> cipherlist = new List<int>();
            List<int> keylist = new List<int>();

            string alfabe = "!'^+%&/()=?_;:<>|.,£#$½{[]}-~` abcçdefgğhıijklmnoöprsştuüvyzwxqé§╚æ■ñø@¢¤¥¦©ª¬®¯°±²³µ¶¹º¼¾ÆÐÞßþûð₿ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZQWX1234567890";
            int alfabesıra1 = 0;
            int alfabesıra2 = 0;

            foreach (char c in ciphertext)
            {
                foreach (char a in alfabe)
                { 
                    if (c == a)
                    {
                        cipherlist.Add(alfabesıra1);
                    }
                    alfabesıra1++;
                }
                alfabesıra1 = 0;
            }
            foreach (char k in key)
            {
                foreach (char a in alfabe)
                {
                    if (k == a)
                    {
                        keylist.Add(alfabesıra2);
                    }
                    alfabesıra2++;
                }
                alfabesıra2 = 0;
            }

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < ciphertext.Length; i++)
            {
                builder.Append(alfabe[(((cipherlist[i] - keylist[i % keylist.Count]) + 140) % 140)]);
            }

            string decryptedcipher = builder.ToString();
            return decryptedcipher;

        }
    }
}
