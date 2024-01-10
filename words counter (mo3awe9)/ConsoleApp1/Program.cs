Console.Write("Please enter your words: ");
string user = Convert.ToString(Console.ReadLine()); Console.Write("\n");

int wordsNumber = wordcounter(user);
Console.WriteLine("you entered " + wordsNumber + " words");


static int wordcounter(string words)
{
    int resualt = 1;
    for(int i = 0; i < words.Length; i++)
    {
        if (words[i] == ' ')
        {
            resualt++;
        }
        else
        {
            continue;
        }
        
    }
    return resualt;
}