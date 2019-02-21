using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        //I know this probably isn't needed, but it's good practice to have it.
        word = word.ToLower();
        //Create a list where you'll be storing your characters
        List<char> characters = new List<char>();

        //Loop through the characters in the word
        foreach(char character in word)
        {
            //If the character equals a space or hyphen, then skip it since we can have multiples of those.
            if(character == ' ' || character == '-')
            {
                continue;
            }
            //If the character list contains the character, it's not an isogram, so we can automatically return false.
            if (characters.Contains(character))
            {
                return false;
            }
            //If the character list doesn't contain the character, then we add it.
            else
            {
                characters.Add(character);
            }
        }
        //Return true because we've looped through all the characters in the word without returning false. This means the word is an isogram.
        return true;
    }
}
