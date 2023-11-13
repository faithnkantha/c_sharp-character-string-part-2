using System;
class QuestionTwo
{
    static void Main()

    {
        char letter;


        Console.WriteLine("Enter a number ,letter or special character");
        letter = Convert.ToChar(Console.ReadLine());
        if (char.IsLetter(letter))
        {
            if (char.IsUpper(letter))
                Console.WriteLine($"{letter}is a capital letter");
            else
                Console.WriteLine($"{letter}is a small letter");
        }
        else
            Console.WriteLine("it's not a letter");


        
    }
}
