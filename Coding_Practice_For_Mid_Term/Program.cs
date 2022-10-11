using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice_For_Mid_Term
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter your word : ");
             string word = Console.ReadLine();
             Exercice1(word);
             Console.ReadKey();
            */

            /*Console.WriteLine("Choose your sequence of numbers length :");
            int[] sequence = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Enter your sequence of numbers : ");
            for(int i=0; i<sequence.Length; i++)
            {
                sequence[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The given array of integers is : 31937472018392");
            Exercice2(sequence);
            Console.ReadKey();
            */

            /*Console.WriteLine("Enter your word : ");
            string word = Console.ReadLine();
            byte [] new_Word = Exercice3_a(word);
            for(int i=0; i<word.Length; i++)
            {
                Console.Write(new_Word[i] + " ");
            }
            Console.ReadKey();
            */

            /*
            Console.WriteLine("Enter your word : ");
            string word = Console.ReadLine();
            Exercice3_b(word);
            
            Console.ReadKey();
            */

            /*
            Console.WriteLine("Enter your word : ");
            string word = Console.ReadLine();
            Exercice4(word);

            Console.ReadKey();
            */

            /*
            Exercice5();
            Console.ReadKey();
            */

            /*
            Console.WriteLine("Choose the array length :");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Enter the array numbers : ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Exercice6(array);
            Console.ReadKey();
            */


            /*
            Console.WriteLine("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Exercice7(number);

            Console.ReadKey();
            */

            /*
            Console.WriteLine("Enter a sentence : ");
            string sentence = Console.ReadLine();
            Exercice8(sentence);

            Console.ReadKey();
            */


            /*Exercice9();
            Console.ReadKey();
            */


        }
        /*
        static void Exercice1(string word)
        {
            char first_Character = word[0];
            char last_Character = word[word.Length - 1];
            string new_Word = Convert.ToString(last_Character);
            for(int i=1; i<word.Length-1; i++)
            {
                new_Word += word[i];
            }
            new_Word += first_Character;

            Console.WriteLine("The new word is : "+ new_Word);
        }
        */
        /*
        static void Exercice2(int [] sequence)
        {
            int[] array = new int[] { 3, 1, 9, 3, 7, 4, 7, 2,0, 1, 8, 3, 9, 2 };
            int compteur = sequence.Length;
            Console.WriteLine(compteur);
            bool answer = false;
            for (int i=0; i<array.Length-1; i++)
            {
                if (array[i] == sequence[0])
                {
                    compteur--;
                    for(int j=1; j<sequence.Length; j++)
                    {
                        if (array[i+j] == sequence[j])
                        {
                            compteur--;
                        }
                    }

                    if(compteur<=0)
                    {
                        answer = true;
                    }
                }
                compteur = sequence.Length;
                
            }

            Console.WriteLine("The answer is : " + answer);       
        }
        */

        static byte[] Exercice3_a(string word)
        {
            byte[] array = Encoding.ASCII.GetBytes(word);

            return array;
        }

        /*static void Exercice3_b(string word)
        {
            byte[] word_ASCII = Exercice3_a(word);
            byte[] word_ASCII_Descending = new byte[word_ASCII.Length];
            int indice = 0;
            byte bigger = 0;

            for (int j = 0; j < word_ASCII.Length; j++)
            {
                for (int i = 0; i < word_ASCII.Length; i++)
                {
                    if (bigger >= word_ASCII[i])
                    {

                    }
                    else
                    {
                        bigger = word_ASCII[i];
                        indice = i;
                    }
                }
                word_ASCII_Descending[j] = bigger;
                bigger = 0;
                word_ASCII[indice] = 0;
            }


            char[] array_Chars = new char[word_ASCII_Descending.Length];
            for (int i = 0; i < array_Chars.Length; i++)
            {
                array_Chars[i] = Convert.ToChar(word_ASCII_Descending[i]);
            }

            for(int i = 0; i < array_Chars.Length; i++)
            {
                Console.Write(array_Chars[i]);
            }

        }
        */

        /*
        static void Exercice4(string word)
        {
            char repetition = word[0];
            bool start = true;
            int number_repetition = 0;
            string new_word = "";
            for(int i=0; i<word.Length; i++)
            {
                if (word[i] == repetition && start == false)
                {
                    number_repetition++;
                }
                else
                {
                    if (number_repetition > 1)
                    {
                        new_word += number_repetition;
                    }
                    repetition = word[i];
                    new_word += repetition;
                    
                    number_repetition = 1;
                    start = false;


                }
                
                if(i==word.Length-1)
                {
                    new_word += number_repetition;
                }
            }

            Console.WriteLine(new_word);
        }
        */
       
        /*
        static void Exercice5()
        {
            string list = "";
            for(int i=0; i<10; i++)
            {
                if (Math.Pow(i,3)==i)
                {
                    list = list+ " "+i;
                }
            }
            for (int i = 10; i < 100; i++)
            {
                if(Math.Pow(i/10,3)+Math.Pow((i- ((i / 10) * 10) )% 10,3)==i)
                {
                    list = list + " " + i;
                }

            }
            for (int i = 100; i < 1000; i++)
            {
                if (Math.Pow(i / 100, 3) + Math.Pow((i-(i/100)*100) / 10, 3)+ Math.Pow((i - (i / 10) * 10)% 10,3) == i)
                {
                    list = list + " " + i;
                }
            }

            Console.WriteLine(list);    
        }
        */

        /*
        static void Exercice6(int[] array)
        {
            int compteur = 0;
            for(int i=0; i<1000; i++)
            {
                for(int j=0; j<array.Length; j++)
                {
                    if (array[j]==i)
                    {
                        compteur++;
                    }
                }
                if (compteur > 0)
                {

                    Console.WriteLine("There is " + compteur + " " + i + " in the array.");
                }
                compteur = 0;
            }
        }
        */

        /*
        static void Exercice7(int number)
        {
            int compteur = number;
            int factorial = 1;
            while(compteur>0)
            {
                factorial *= compteur;
                compteur--;
            }

            Console.WriteLine("The factorial of " + number + " is " + factorial);
        }
        */

        /*        
        static void Exercice8(string sentence)
        {
            int compteur = 0;
            char space = ' ';
            for(int i=0; i<sentence.Length; i++)
            {
                if(sentence[i] == space)
                {
                    compteur++;
                }
            }

            Console.WriteLine("There are " + compteur + " in the sentence.");
        }
        */

        /*static void Exercice9()
        {
            Console.WriteLine("Give three names : ");
            Person [] person = new Person[3] ;
            for(int i=0; i<3; i++)
            {
                person[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                person[i].ToStringName();
            }

        }
        */

     
        
    }
}
