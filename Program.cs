using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list with numbers from 1 to 10000
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 10000; i++)
        {
            numbers.Add(i);
        }

        // Shuffle the list
        ShuffleList(numbers);

        // Display the shuffled numbers
        foreach (int num in numbers)
        {
            Console.WriteLine(num + '\n');
        }
    }



    /// <summary>
    /// This funtion is use to swap element within the list
    /// It create a temporary varialbe `temp` to store value of the elemetn at the current index 'i' in the list,
    /// that value will later be used to perform a swap operation with another element in the list
    /// </summary>
    /// <param name="list">List for shuffle</param>
    static void ShuffleList<G>(List<G> list)
    {
        Random rand = new Random();
        int n = list.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int j = rand.Next(0, i + 1);
            G temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
