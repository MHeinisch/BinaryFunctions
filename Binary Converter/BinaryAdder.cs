using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Converter
{
    class BinaryAdder
    {

        //member variables
        public List<bool> boolListOne = new List<bool>();
        public List<bool> boolListTwo = new List<bool>();
        public List<bool> boolListAdded = new List<bool>();

        int remainingUserInput;
        int carryOver = 0;




        public BinaryAdder()
        {
         
        }



        public void getUserIntsToAdd()
        {

        }

        public int GetUserInput()
        {
                int inputNumber;
                Console.WriteLine("What integer would you like converted to binary?");
                Int32.TryParse(Console.ReadLine(), out inputNumber);
                return inputNumber;      
        }

        public List<bool> ConvertToBinary(int Int)
        {
            remainingUserInput = Int;
            List<bool> boolList = new List<bool>();
            for (int power = 31; power >= 0; power--)
            {
                FillBinaryList(power, boolList);
            }
            PrintBinaryNumber(boolList);
            return boolList;
        }
            

            public void FillBinaryList(int Power, List<bool> boolList)
            {
                if (remainingUserInput >= Math.Pow(2, Power))
                {
                    boolList.Add(true);
                    remainingUserInput -= Convert.ToInt32(Math.Pow(2, Power));
                }
                else
                {
                    boolList.Add(false);
                }
            }

            public void PrintBinaryNumber(List<bool> binaryNum)
            {
            Console.WriteLine("Your number in binary is:");
                for (int index = 0; index < binaryNum.Count(); index++)
                {
                    if (binaryNum[index] == true)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
            Console.WriteLine();
        }

        public void AddBinaryNumbers(List<bool> boolList1, List<bool> boolList2)
        {
            Console.WriteLine("Now to add your two binary numbers...");
            for (int index = 31; index >= 0; index--)
            {
                CheckForCarryOver(boolList1, boolList2, index);
            }
            PrintBinaryNumber(boolListAdded);
        }

            public void CheckForCarryOver(List<bool> boolList1, List<bool> boolList2, int Index)
            {
                if (carryOver == 0)
                {
                    AddWithNoCarryOver(boolList1, boolList2, Index);
                }
                else if (carryOver == 1)
                {
                    AddWithCarryOver(boolList1, boolList2, Index);
                }
            }

                public void AddWithNoCarryOver(List<bool> boolList1, List<bool> boolList2, int Index)
                {
                    if (boolList1[Index] == false && boolList2[Index] == false)
                    {
                        boolListAdded.Insert(0, false);
                        carryOver = 0;
                    }
                    else if ((boolList1[Index] == true && boolList2[Index] == false) || (boolList1[Index] == false && boolList2[Index] == true))
                    {
                        boolListAdded.Insert(0, true);
                        carryOver = 0;
                    }
                    else if(boolList1[Index] == true && boolList2[Index] == true)
                    {
                        boolListAdded.Insert(0, false);
                        carryOver = 1;
                    }
                }

                public void AddWithCarryOver(List<bool> boolList1, List<bool> boolList2, int Index)
                {
                    if (boolList1[Index] == false && boolList2[Index] == false)
                    {
                        boolListAdded.Insert(0, true);
                        carryOver = 0;
                    }
                    else if ((boolList1[Index] == true && boolList2[Index] == false) || (boolList1[Index] == false && boolList2[Index] == true))
                    {
                        boolListAdded.Insert(0, false);
                        carryOver = 1;
                    }
                    else if (boolList1[Index] == true && boolList2[Index] == true)
                    {
                        boolListAdded.Insert(0, true);
                        carryOver = 1;
                    }
        }
    }

}
