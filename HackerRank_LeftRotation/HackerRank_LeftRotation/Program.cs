using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean isValid = false;
            string[] userParams = null;
            int numOfInts = 0;
            int numOfShifts = 0;
            string[] userArray = null;
            string[] output = null;
            //string output = null;

            while (!isValid)
            {
                userParams = Console.ReadLine().Split(' ');
                numOfInts = int.Parse(userParams[0]);
                numOfShifts = int.Parse(userParams[1]);
                userArray = Console.ReadLine().Split(' ');
                output = new string[userArray.Length];

                if (numOfInts >= numOfShifts)
                    isValid = true;
                else
                    Console.WriteLine("Error: Please enter vaild input.");
            }

            if (numOfShifts == numOfInts)
            {
                foreach (string s in userArray)
                    Console.Write(s + " ");
            }
            else
            {
                Array.Copy(userArray, 0, output, numOfInts - numOfShifts, numOfShifts);
                Array.Copy(userArray, numOfShifts, output, 0, numOfInts - numOfShifts);
                /*for (int i = numOfShifts; i < numOfInts; i++)
                {
                    output += userArray[i] + " ";
                }
                for (int i = 0; i < numOfShifts; i++)
                {
                    output += userArray[i] + " ";
                }*/
            }
            string displayString = null;
            foreach (string s in output)
            {
                displayString += s + " ";
            }
            //Console.WriteLine(output.Trim());
            Console.WriteLine(displayString.Trim());
            Console.ReadKey();
        }
    }
}
