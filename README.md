## Strategy

The algorithm finds the most frequent number in an integer array.

A `Dictionary<int, int>` is used to count how many times each number appears in the array.  
The program iterates through the array with a `foreach` loop and updates the dictionary with the frequency of each number.

After counting all numbers, the dictionary is checked to find the number with the highest frequency.  
If multiple numbers have the same frequency, the smallest number is returned.
