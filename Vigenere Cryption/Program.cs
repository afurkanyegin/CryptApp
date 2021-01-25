using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string plaintext = Console.ReadLine();
            string key = Console.ReadLine();

            string ciphertext = Vigenere.vigenerecrypt(plaintext, key);
            Console.WriteLine("Encrypted Text = {0}" , ciphertext);

            string decryptedciphertext = Vigenere.vigeneredecrypt(ciphertext, key);
            Console.WriteLine("Decrypted Text = {0}" , decryptedciphertext);






















            //List<int> plainlist = new List<int>();
            //List<int> keylist = new List<int>();
            //List<int> cipherlist = new List<int>();
            //List<int> encryptedcipherlist = new List<int>();
            //List<int> decryptedcipherlist = new List<int>();

            //string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
            //int alfabesıra1 = 0;
            //int alfabesıra2 = 0;
            //int alfabesıra3 = 0;


            //foreach (char p in plaintext)
            //{
            //    foreach(char a in alfabe)
            //    {
            //        if (p == a)
            //        {
            //            plainlist.Add(alfabesıra1);
            //        }
            //        alfabesıra1++;
            //    }
            //}
            //foreach (char p in key)
            //{
            //    foreach (char a in alfabe)
            //    {
            //        if (p == a)
            //        {
            //            keylist.Add(alfabesıra2);
            //        }
            //        alfabesıra2++;
            //    }
            //}
            //for (int i = 0; i < plainlist.Count; i++)
            //{
            //    cipherlist.Add(alfabe[((plainlist[i] + keylist[i%keylist.Count])%29)]);
            //}
            //foreach(var c in cipherlist)
            //{
            //    Console.Write((char)c);
            //}

            //Console.WriteLine(String.Empty);

            //foreach (char p in cipherlist)
            //{
            //    foreach (char a in alfabe)
            //    {
            //        if (p == a)
            //        {
            //            encryptedcipherlist.Add(alfabesıra3);
            //        }
            //        alfabesıra3++;
            //    }
            //}
            //for (int i = 0; i < cipherlist.Count; i++)
            //{
            //    decryptedcipherlist.Add(alfabe[(((encryptedcipherlist[i] - keylist[i % keylist.Count])+29)%29 )]);
            //}
            //foreach (var d in decryptedcipherlist)
            //{
            //    Console.Write((char)d);
            //}

            //foreach(var g in plaintext)
            //{

            //foreach(var p in plaintext)
            //{
            //    for(int i = 0; i < alfabe.Length; i++)
            //    {
            //        if (p == alfabe[i])
            //        {
            //                plainlist.Add(i);
            //        }
            //    }
            //}

            //foreach (var k in key)
            //{
            //    for (int i = 0; i < alfabe.Length; i++)
            //    {
            //        if (k == alfabe[i])
            //        {
            //                keylist.Add(i);
            //        }
            //    }
            //}
            //    int sonuç = 0;
            //    if (keylist.Count < plainlist.Count)
            //    {
            //        foreach(var l1 in plainlist)
            //        {

            //        }
            //    }
            //char s = alfabe[sonuç];

            //Console.Write(s);


            //}

            //foreach (char p in plaintext)
            //{

            //    plain.Add(p-97);
            //}
            //foreach(char y in key)
            //{
            //    keyy.Add(y-97);
            //}
            //foreach (char p in plain)
            //{
            //    cipher.Add(((p + keyy[a])%26)+97);
            //    a++;
            //    if (a == key.Length) a = 0;
            //}
            //foreach (char p in cipher)
            //{
            //    Console.Write(p);
            //}

            //ç &#231;
            //ı &#305;
            //ğ &#287;
            //ö &#246;
            //ş &#351;
            //ü &#252;

            //Ç &#199;
            //İ &#304;
            //Ğ &#208;
            //Ö &#214;
            //Ş &#350;
            //Ü &#220;

            //string ciphertext = Vigenere.vigenerecrypt(plaintext, key);

            //string solvedplaintext = Vigenere.vigeneredecrypt(ciphertext, key);


            //foreach (var a in plaintext)
            //{
            //    b.Add(a + 11);
            //}
            //foreach (var c in b)
            //{
            //    Console.WriteLine((char)c);
            //}


        }
    }
}
