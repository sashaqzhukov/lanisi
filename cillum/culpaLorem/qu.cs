using System;
using System.Text;

public class WordGenerator
{
    private static readonly Random random = new Random();

    // Generates a string containing the specified number of random words.
    public string GenerateWords(int count)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            builder.Append(GenerateRandomWord()).Append(' ');
        }
        // Remove the last space
        if (builder.Length > 0)
        {
            builder.Length--;
        }
        return builder.ToString();
    }

    // Generates a random word of random length.
    private string GenerateRandomWord()
    {
        int length = random.Next(3, 10); // Random word length between 3 and 10 characters
        StringBuilder wordBuilder = new StringBuilder(length);
        for (int j = 0; j < length; j++)
        {
            // Append a random lowercase letter
            wordBuilder.Append((char)('a' + random.Next(0, 26)));
        }
        return wordBuilder.ToString();
    }
}
