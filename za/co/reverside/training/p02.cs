using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace BasicProgramming
{
   public class IterationProgramming
    {
        //*********************************************************************************************************************************************
        //Iteration Exercises:
        public int LargestNum_N(int[] arrays)
        {
            int largestNum = 0;
            for (int x = 0; x < arrays.Length - 1; x++)
            {
                if (arrays[x] > arrays[x + 1])
                {
                    if (arrays[x] > largestNum)
                    {
                        largestNum = arrays[x];
                    }
                }
            }
            return largestNum;
        }
        public int _2nd_LargestNum_N(int[] arrays)
        {
            int largestNum = 0;
            for (int x = 0; x < arrays.Length - 1; x++)
            {
                if (arrays[x] > arrays[x + 1])
                {
                    if (arrays[x] > largestNum)
                    {
                        largestNum = arrays[x + 1];
                    }
                }
            }
            return largestNum;
        }
        public bool Is_num_Present_N(int[] arrays, int find_num)
        {
            for (int x = 0; x < arrays.Length; x++)
            {
                if (arrays[x] == find_num) return true;
            }
            return false;
        }
        public void occurrences_N(int[] arrays)
        {
            var arraysId = arrays.GroupBy(z => z);
            foreach (var array in arraysId)
            {
                Console.WriteLine(array.Key + " -> " + array.Count());
            }
        }
        public void maxNum_occurrences_N(int[] arrays)
        {

            int mostOccur = 0, numOccurrences = 0;
            int currentNum = 0, currentValOccurences;

            for (int i = 0; i < arrays.Length; i++)
            {
                currentNum = arrays[i];
                currentValOccurences = 0;

                for (int j = 0; j < arrays.Length; j++)
                {
                    if (currentNum == arrays[j])
                        currentValOccurences += 1;
                }

                if (currentValOccurences > numOccurrences)
                {
                    numOccurrences = currentValOccurences;
                    mostOccur = currentNum;
                }

            }

            Console.WriteLine(" The number {0} occurres {1} times", mostOccur, numOccurrences);

        }
        public int Num_spaces_N(string sentence)
        {
            int count_spaces = 0;
            for (int x = 0; x < sentence.Length; x++)
            {
                if (sentence[x] == ' ')
                {
                    count_spaces++;
                }
            }
            return count_spaces;
        }
        public int Num_words_N(string sentence)
        {
            int count_words = 0;
            for (int x = 0; x < sentence.Length; x++)
            {
                if (sentence[x] == ' ')
                {
                    count_words++;
                }
            }
            return count_words + 1;
        }
        public string replace_spaces_N(string sentence)
        {
            return sentence.Replace(' ', '_');
        }
        public void sort_Ascending_N(int[] arrays)
        {
            int sort = 0;

            for (int x = 0; x < arrays.Length; x++)
            {
                for (int y = 0; y < arrays.Length - 1; y++)
                {
                    if (arrays[y] > arrays[y + 1])
                    {
                        sort = arrays[y + 1];
                        arrays[y + 1] = arrays[y];
                        arrays[y] = sort;
                    }
                }
                Console.Write(arrays[x] + " ");
            }
        }
        public void all_even_N(int[] arrays)
        {
            for (int x = 0; x < arrays.Length; x++)
            {
                if (arrays[x] % 2 == 0) Console.Write(arrays[x] + " ");
            }
        }
        public void Reverse_str(string str)
        {
            for (int x = str.Length - 1; x > 0; x--)
            {
                Console.Write(str[x]);
            }
        }
        public string Num_to_str(int num)
        {
            return num.ToString();
        }
        public double count_digits(int num)
        {
            return Math.Floor(Math.Log10(num) + 1);
        }
        public bool Is_vowel(char alphabet)
        {
            alphabet = char.ToLower(alphabet);
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == '0' || alphabet == 'u') return true;
            else return false;
        }
        
    }
	
    class Program
    {
        static void Main(string[] args)
        {
			int[] array = new int[10] { 23, 21, 23, 43, 21, 54, 67, 54, 34, 23 };
            string sentence = "Dog is barking the owner";
            int find = 11;
            int number = 1200;
            char vowel = 'z';
			
            IterationProgramming Iteration = new IterationProgramming();
            //Iteration Exercises:------------------------------------------------------
            Console.WriteLine("Largest Number in array is " + Iteration.LargestNum_N(array));
            Console.WriteLine("Second Largest Number in array is " + Iteration._2nd_LargestNum_N(array));
            Console.WriteLine("Is there " + find + " in array " + Iteration.Is_num_Present_N(array, find));
            Iteration.occurrences_N(array);
            Iteration.maxNum_occurrences_N(array);
            Console.WriteLine("Number of spaces in the sentence is " + Iteration.Num_spaces_N(sentence));
            Console.WriteLine("Number of Words in the sentence is " + Iteration.Num_words_N(sentence));
            Console.WriteLine("Spaces replaced with '_'  " + Iteration.replace_spaces_N(sentence));
            Iteration.sort_Ascending_N(array);
            Iteration.all_even_N(array);
            Iteration.Reverse_str(sentence);
            Console.WriteLine("Number to string  " + Iteration.Num_to_str(number));
            Console.WriteLine("Count digits in number " + number + " : " + Iteration.count_digits(number));
            Console.WriteLine(vowel + " is a vowel " + Iteration.Is_vowel(vowel));
			
            Console.WriteLine("\n Press any key to close");
            Console.ReadKey();
        }
    }
}
