using System;

namespace PetApplication
{
    class myPetProgram
    {
        static void Main(string[] args)
        {
            //Create an object of the Pet class
            Pet petobj = new Pet();

            //Use the object
            petobj.Start();

            petobj.ReadAndSavePetData();

            Console.Write(petobj.PrintPetData());

            // space to infotext
            Console.WriteLine();

        }
    }
}

