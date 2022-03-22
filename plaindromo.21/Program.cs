using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string valor = "";
        foreach (string s in System.IO.File.ReadLines(@"C:\Users\alberto.barbosa\Desktop\aquivo txt\txt.palindromo.txt"))
        {
            string word, revs = "";
            word = s;
            if (word != null)
            {
                for (int i = s.Length - 1; i >= 0; i--) //le a string de maneira reversa
                {

                    revs += word[i].ToString();
                }
                if (revs == word) // aqui checa se é palindromo ou não
                {
                    valor = "A palavra " + word + " é um palindromo";
                    Console.WriteLine(valor); // se for a mesma palavra de trás para frente
                }
                else
                {
                    valor = "A palavra " + word + " não é um palindromo";
                    Console.WriteLine(valor); // se a palavra não for a mesma
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Users\alberto.barbosa\Desktop\aquivo txt\resposta.txt", true))
                {
                    writer.WriteLine(valor);
                }
            }
        }
    }
}

