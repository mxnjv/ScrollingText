using System.Threading;

//- Declaring function with arguements: string str and int timing
static dynamic Text_scroll(string str, int timing)
{
    str.Split(); //- Splits str into an array for each character

    for (int i = 0; i < str.Length; i++) //- For each element in the function
    {
        Console.Write(str[i]);  //- Uses Console.Write() because Console.WriteLine() will make a new line which is bad! 
        Thread.Sleep(timing);   //- The small pause there is to create the scrolling effect.
    }


    return str;
    return timing;    //- Returning arguements


}

Text_scroll("Use function above to write scrolling text!", 10);                               //- Change text and speed
Text_scroll("\nSomeone else has definitely done this before but I still want to do it.", 50);

Console.ReadKey();  //- Code doesn't instantly close