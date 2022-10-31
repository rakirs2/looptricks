NumberOfStars(5);
UnderscoresAndStars(7);
AlternatingValues(3);

// Prints triangle of stars (see problem 1)
 static void NumberOfStars(int numStars)
 {
     var i = 1;
     // while the count of stars per row is less than or equal to the number I want
     while (i <= numStars)
     {
         // create the string of stars
         string output = "";
         var j = 0;
      
         // this is similiar to i*'*' in python
         while (j < i)
         {
             output = output + "*";
             j++;
         }
         // print it
         Console.WriteLine(output);
         i++;
     }
 }
 
// Prints triangle of stars with underscores
static void UnderscoresAndStars(int numStars)
{
    // key determination is that we always have 5 characters printed
    var output = "";
    // create a string of stars thats length numstars
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
        //change the nth position repeatedly
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
            //this is like the fizz buzz trick
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
