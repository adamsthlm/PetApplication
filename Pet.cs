using System;

namespace PetApplication
{
    class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Greedings from a Pet object!");
            Console.WriteLine();        
        }

        public void ReadAndSavePetData()
        {
            Console.Write("What's the name of your pet? ");
            name = Console.ReadLine();

            Console.Write("What's the age of your pet? ");
            String textValue = Console.ReadLine();
            age = int.Parse(textValue);

            Console.Write( "Is your pet female? (y/n) " );

            char responce = char.Parse(Console.ReadLine());
            if ((responce == 'y') || (responce == 'Y'))
                isFemale = true;
            else
                isFemale = false; 

        }

        public string PrintPetData()
        {
            Console.WriteLine();
            string textOut = "Name: " + name
               + "\nAge: " + age;
            Console.WriteLine();

            // addar olika strängar beroende på isFemale 1 | 0
            if (isFemale == true)
            {
                textOut = textOut + "\nit's a girl!";
            }
            else
                textOut = textOut + "\nits' a boy!";
            return textOut;
        }


    }

}