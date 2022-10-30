NumberOfStars(5);
UnderscoresAndStars(7);
AlternatingValues(3);

// Prints triangle of stars (see problem 1)
 static void NumberOfStars(int numStars)
 {
     var i = 1;
     while (i <= numStars)
     {
         string output = "";
         var j = 0;
         while (j < i)
         {
             output = output + "*";
             j++;
         }
         Console.WriteLine(output);
         i++;
     }
 }
 
// Prints triangle of stars (see problem 1)
static void UnderscoresAndStars(int numStars)
{

    var output = "";
    for (
        int i = 0;
        i < numStars;
        i++)
    {
        output += "*";
    }

    for (int i = 0;
         i < numStars;
         i++)
    {
        output = output.Remove(i, 1).Insert(i, "_");
        Console.WriteLine(output);
    }
}

static void AlternatingValues(int numStars)
{
    var i = 1;
    while (i <= numStars)
    {
        string output = "";
        var j = 0;
        while (j < i)
        {
            if (j % 2 == 0)
            {
                output = output + "*";
            }
            else
            {
                output = output + "_";
            }
            j++;
        }
        Console.WriteLine(output);
        i++;
    }
}