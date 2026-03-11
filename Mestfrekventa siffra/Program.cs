using System;
using System.Collections.Generic;

class Program
{
	public static int MostFrequentNumber(int[] arr)
	{
		// Dictionary fungerar som en tabell:
		// siffran
		// antal gånger siffran kommer upp
		Dictionary<int, int> frequency = new Dictionary<int, int>();

		// Gå igenom varje siffra i arrayen separat och uppdatera dictionaryn
		foreach (int number in arr)
		{
			// Om siffran redan finns i dictionaryn
			if (frequency.ContainsKey(number))
			{
				// öka antalet med 1
				frequency[number]++;
			}
			else
			{
				// annars lägg till siffran med värdet 1
				frequency[number] = 1;
			}
		}

		// en variabel för att hålla reda på den högsta frekvensen
		int maxFrequency = 0;

		// Variabel för vilken siffra som ska returneras
		int result = int.MaxValue;

		// Gå igenom dictionaryn för att hitta mest frekventa siffran
		foreach (var pair in frequency)
		{
			int number = pair.Key;   // själva siffran
			int count = pair.Value;  // hur många gånger den förekommer

			// Om denna siffra förekommer fler gånger än den tidigare mest frekventa siffran
			if (count > maxFrequency)
			{
				maxFrequency = count;
				result = number;
			}
			// Om två siffror har samma frekvens
			// välj den minsta siffran
			else if (count == maxFrequency && number < result)
			{
				result = number;
			}
		}

		return result;
	}

	static void Main()
	{
		Console.WriteLine(MostFrequentNumber(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 })); // 2
		Console.WriteLine(MostFrequentNumber(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 })); // 1
		Console.WriteLine(MostFrequentNumber(new int[] { -1, -1, -2, -2, -2 })); // -2
	}
}