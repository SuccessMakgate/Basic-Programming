using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace BasicProgramming
{
    public class PatternProgramming
    {
        //*********************************************************************************************************************************************
        //Star Pattern Exercises

        //Square Star
        public void Square_Star()
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write("*");
                }
                Console.Write("*\n");
            }

        }
        public void Hollow_Square()
        {
            int n = 10;
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (x == 0 || x == n - 1 || y == 0 || y == n - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
        public void Hollow_Square_star_Diagonal()
        {
            int N = 10;

            for (int x = 1; x <= N; x++)
            {
                for (int y = 1; y <= N; y++)
                {
                    if (x == 1 || x == N || y == 1 || y == N || x == y || y == (N - x + 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\n");
            }

        }
        //Rhombus Star
        public void Rhombus_Star()
        {
            int rows = 10;

            for (int x = 1; x <= rows; x++)
            {
                for (int y = x; y < rows; y++)
                {
                    Console.Write(" ");
                }

                for (int y = 1; y <= rows; y++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public void Hollow_Rhombus_Star()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                if (i == 1 || i == 10)
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write("*");
                    }
                else
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        if (j == 1 || j == 10)
                            Console.Write("*");
                        else

                            Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
        public void Mirrored_Rhombus_Star()
        {
            int n = 10;
            int i, j;

            for (i = 1; i <= n; i++)
            {
                for (j = i; j < n; j++)
                    Console.Write(" ");

                for (j = 1; j <= n; j++)
                    Console.Write("*");

                Console.Write("\n");
            }
        }
        public void Hollow_Mirrored_Rhombus_Star()
        {
            int n = 10;
            int i, j;

            for (i = 1; i <= n; i++)
            {
                for (j = i; j < n; j++)
                    Console.Write(" ");

                for (j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.Write("\n");
            }

        }
        //Right Triangle Star
        public void Right_Triangle_Star()
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    Console.Write("*");
                }
                Console.Write("*\n");
            }

        }
        public void Hollow_Right_Triangle_Star()
        {
            for (int x = 1; x <= 10; x++)
            {
                if (x == 1 || x == 10)
                    for (int y = 1; y <= x; y++)
                    {
                        Console.Write("*");
                    }
                else
                {
                    for (int y = 1; y <= x; y++)
                    {
                        if (y == 1 || y == x) Console.Write("*");
                        else Console.Write(" "); ;
                    }
                }
                Console.Write("\n");
            }

        }
        public void Mirrored_Right_Triangle_Star()
        {
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    if (j <= 10 - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.Write("\n");
            }
        }
        public void Mirrored_Hollow_Right_Triangle_Star()
        {
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    if (j <= 10 - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.Write("\n");
            }
        }
        public void Inverted_Right_Triangle_Star()
        {
            for (int x = 10; x > 0; x--)
            {
                for (int y = x; y > 0; y--)
                {
                    Console.Write("*");
                }
                Console.Write("*\n");
            }
        }
        public void Hollow_Inverted_Right_Triangle_Star()
        {

            int n = 10;
            for (int i = n; i > 0; i--)
            {
                if (i == 1 || i == n)
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j == 1 || j == i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }

        }
        public void Inverted_Mirrored_Right_Triangle_Star()
        {
            int i, j, rows = 10;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (j = i; j <= rows; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
        public void Hollow_Inverted_Mirrored_Right_Triangle_Star()
        {
            int i, j, rows = 10;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (j = i; j <= rows; j++)
                {

                    if (j == i || j == rows || i == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\n");
            }

        }
        //Pyramid Star
        public void Pyramid_Star()
        {
            int i, space, rows = 10, star = 0;

            for (i = 1; i <= rows; i++)
            {

                for (space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }

                while (star != (2 * i - 1))
                {
                    Console.Write("*");
                    star++; ;
                }
                star = 0;

                Console.Write("\n");
            }

        }
        public void Hollow_Pyramid_Star()
        {
            int i, space, star = 0;
            int rows = 10;
            for (i = 1; i < rows; i++)
            {
        
                for (space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }
     
                while (star != (2 * i - 1))
                {
                    if (star == 0 || star == 2 * i - 2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    star++; ;
                }
                star = 0;
 
                Console.Write("\n");
            }
        
            for (i = 0; i < 2 * rows - 1; i++)
            {
                Console.Write("*");
            }
        }
        public void Inverted_Pyramid_Star()
        {
            int i, space, rows = 10, star = 0;


            for (i = rows; i >= 1; i--)
            {
             
                for (space = 0; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }
             
                star = 0;
                while (star != (2 * i - 1))
                {
                    Console.Write("*");
                    star++;
                }
                Console.Write("\n");
            }

        }
        public void Hollow_Inverted_Pyramid_Star()
        {
            int i, j, rows = 10;
          
            for (i = 1; i <= rows; i++)
            {
        
                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= (rows * 2 - (2 * i - 1)); j++)
                {
                  
                    if (i == 1 || j == 1 || j == (rows * 2 - (2 * i - 1)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\n");
            }

        }
        //Diamond Star
        
        public void Half_diamond_star()
        {
            int i, j, N = 10, columns;

            columns = 1;

            for (i = 1; i < N * 2; i++)
            {
                for (j = 1; j <= columns; j++)
                {
                    Console.Write("*");
                }

                if (i < N) columns++;
                
                else  columns--;
               
                Console.Write("\n");
            }
        }
        public void Mirrored_Half_Diamond_Star()
        {
            int i, j, k;
            for (i = 1; i <= 10; i++)
            {
                for (j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 10; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        

    }
	
    class Program
    {
        static void Main(string[] args)
        {
            PatternProgramming pattern = new PatternProgramming();
            //Square------------------------------------ -
            pattern.Hollow_Square();
            pattern.Square_Star();
            pattern.Hollow_Square_star_Diagonal();
            // Rhombus------------------------------------
            pattern.Rhombus_Star();
            pattern.Hollow_Rhombus_Star();
            pattern.Mirrored_Rhombus_Star();
            pattern.Hollow_Mirrored_Rhombus_Star();
            //Right Triangle-----------------------------
            pattern.Right_Triangle_Star();
            pattern.Hollow_Right_Triangle_Star();
            pattern.Inverted_Right_Triangle_Star();
            pattern.Hollow_Inverted_Right_Triangle_Star();
            pattern.Inverted_Mirrored_Right_Triangle_Star();
            pattern.Hollow_Inverted_Mirrored_Right_Triangle_Star();
            pattern.Mirrored_Right_Triangle_Star();
            pattern.Mirrored_Hollow_Right_Triangle_Star();
            // Pyramid------------------------------------
            pattern.Pyramid_Star();
            pattern.Hollow_Pyramid_Star();
            pattern.Inverted_Pyramid_Star();
            pattern.Hollow_Inverted_Pyramid_Star();
            //Diamond------------------------------------
            pattern.Half_diamond_star();
            pattern.Mirrored_Half_Diamond_Star();
			
            Console.WriteLine("\n Press any key to close");
            Console.ReadKey();
        }
    }
}
