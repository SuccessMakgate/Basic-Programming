﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

 namespace BasicProgramming 
  { 
      public class ConditionProgramming 
     { 
           
          //Condition Exercises 
          public int LargestNum_3(int num1, int num2, int num3) 
          { 
              if (num1 >= num2 && num1 >= num3) 
              { 
                  return num1; 
              } 
              else if (num2 >= num1 && num2 >= num3) 
              { 
                  return num2; 
              } 
              else if (num3 >= num1 && num3 >= num2) 
              { 
                  return num3; 
              } 
              else 
              { 
                  return -1; 
              } 
  
 
          } 
          public int _2nd_LargestNum_3(int num1, int num2, int num3) 
          { 
              if (num1 >= num2 && num1 >= num3) 
              { 
                  if (num2 >= num3) return num2; 
                  else return num3; 
              } 
              else if (num2 >= num1 && num2 >= num3) 
              { 
                  if (num1 >= num2) return num1; 
                  else return num3; 
              } 
              else if (num3 >= num1 && num3 >= num2) 
              { 
                  if (num1 >= num2) return num1; 
                  else return num2; 
              } 
              else 
              { 
                  return -1; 
              } 
          } 
          public int LargestNum_7(int num1, int num2, int num3, int num4, int num5, int num6, int num7) 
          { 
              int largestNum = 0; 
              int[] array = new int[7] { num1, num2, num3, num4, num5, num6, num7 }; 
  
 
              for (int x = 1; x < array.Length - 1; x++) 
              { 
                  if (array[x] > array[x + 1]) 
                  { 
                      if (array[x] > largestNum) 
                      { 
                          largestNum = array[x]; 
                      } 
                  } 
              } 
              return largestNum; 
          } 
          public void multiple_of_num(int N_num) 
          { 
              for (int x = 0; x < N_num; x++) 
              { 
                  if ((x % 3) == 0 && N_num % 5 == 0) Console.WriteLine("FizzBuzz @ Num: " + x); 
                  else if ((x % 3) == 0) Console.WriteLine("Fizz @ Num: " + x); 
                  else if ((x % 5) == 0) Console.WriteLine("Buzz @ Num: " + x); 
              } 
          } 
          public string check_P_N(int Num) 
          { 
              if (Num < 0) return "Negative"; 
              else if (Num > 0) return "Positive"; 
              else return "Is Zero"; 
          } 
         public string check_Even_Odd(int Num) 
          { 
              if (Num % 2 == 0) return "Even"; 
              else return "Odd"; 
          } 
          public bool Is_leapYear(int year) 
          { 
              if (year % 100 == 0 && year % 4 != 0) return true; 
              else return false; 
  
 
          } 
  
       } 
             
       
      class Program 
      { 
          static void Main(string[] args) 
          { 
              ConditionProgramming condition = new ConditionProgramming(); 
               
              Console.WriteLine("Largest Number is " + condition.LargestNum_3(10, 20, 30)); 
              Console.WriteLine("Largest Number is " + condition._2nd_LargestNum_3(80, 70, 50)); 
              Console.WriteLine("Largest Number is " + condition.LargestNum_7(10, 20, 80, 50, 34, 15, 67)); 
              condition.multiple_of_num(30); 
              Console.WriteLine("The Number is : " + condition.check_P_N(-12)); 
              Console.WriteLine("The Number is : " + condition.check_Even_Odd(6)); 
              Console.WriteLine("Is the leap Year ? : " + condition.Is_leapYear(2016)); 
      
              Console.WriteLine("\n Press any key to close"); 
              Console.ReadKey(); 
          } 
      } 
  } 

