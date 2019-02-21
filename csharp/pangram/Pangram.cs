using System;

public static class Pangram
{
    static char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                      'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

    public static bool IsPangram(string input)
    {
        int counter = 0;

        foreach(char letter in letters)
        {
            if (input.ToLower().Contains(letter))
            {
                counter++;
            }
        }
        return counter == 26 ? true : false;
    }
}
