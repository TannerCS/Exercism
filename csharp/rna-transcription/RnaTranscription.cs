using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        string Rna = "";

        foreach(char character in nucleotide)
        {
            if (character == 'G')
                Rna += "C";
            else if (character == 'C')
                Rna += "G";
            else if (character == 'T')
                Rna += "A";
            else if (character == 'A')
                Rna += "U";
        }

        return Rna;
    }
}