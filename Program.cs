using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"D:\#Панкова\test\4_2.txt";
        int n = 100000;
        int A = 100;
        int result = Stairs(filePath, n, A);
        Console.WriteLine("Answer: " + result);
    }

    static int Stairs(string filePath, int n, int A)
    {
        // Чтение данных из файла и сохранение в список nums
        List<int> nums = new List<int>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line = reader.ReadLine();
            string[] elements = line.Split(' ');

            foreach (string element in elements)
            {
                if (int.TryParse(element, out int num))
                {
                    nums.Add(num);
                }
            }
        }

        int answer = 0;
        int len = nums.Count;

        for (int i = 0; i < len; i++)
        {
            for (int j = i; j < len; j++)
            {
                if (nums[j] != j - i + 1)
                {
                    if (j - i == A)
                    {
                        answer++;
                    }
                    break;
                }
            }
        }

        return answer;
    }
}