
//using System.Text;
//Console.WriteLine("Введите текст");
//string sb1 = Console.ReadLine();
//StringBuilder sb = new StringBuilder();
//sb.Append(sb1);
//средний уровень вариант 6 


using System;
using System.Text;
  
        string inputString = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        foreach (char c in inputString)
        {
            result.Append(c);
            result.Replace("*","<>"); //я не понял что требовалось вставить после * поэтому поставил <>
        }

        string outputString = result.ToString();
        Console.WriteLine(outputString);