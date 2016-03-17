using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryAdder binary = new BinaryAdder();

            int inputIntOne;
            int inputIntTwo;

            inputIntOne = binary.GetUserInput();
            binary.boolListOne = binary.ConvertToBinary(inputIntOne);

            inputIntTwo = binary.GetUserInput();
            binary.boolListTwo = binary.ConvertToBinary(inputIntTwo);

            binary.AddBinaryNumbers(binary.boolListOne, binary.boolListTwo);

            Console.WriteLine("In decimal form , your number is " + (inputIntOne + inputIntTwo));

            Console.ReadLine();

        }
    }
}
