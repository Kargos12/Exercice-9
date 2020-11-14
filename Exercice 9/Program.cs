using System;
/**
 *Exercice 9
 *Author : Kargos
 *04/11/2020
 */

namespace Exercice_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            float Note;

            //faire ca :
            do
            {
                Console.Write("Saisissez une note entre 0 et 20 : ");
                Note = float.Parse(Console.ReadLine());
            }

            // tant que ca :
            while (Note>20 || Note<0);

            //sinon :
            Console.WriteLine("La note est de : " + Note);
           
            Console.ReadLine();
        }
        
    }
}
