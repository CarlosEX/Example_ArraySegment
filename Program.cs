// https://carlosantoniocison.editorx.io/portifolio
using System;
using Example_ArraySegment.Entities;
using Example_ArraySegment.ExampleArraySegment;

namespace Example_ArraySegment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("PRINT PATTERNS\n");

            var arraySegementPatterns = new ArraySegmentDesignPattern();
            arraySegementPatterns.PrintAllPatterns();
            arraySegementPatterns.PrintRangePatternBehavioral();
            arraySegementPatterns.PrintRangePatternCreational();
            arraySegementPatterns.PrintRangePatternStructural();
            arraySegementPatterns.CountGroupPatternsLinq();
            arraySegementPatterns.GetListPatternsWichoSlice(3);
            arraySegementPatterns.GetListPatternsWichoSlice(index:2,count:3);

            
            Console.WriteLine();
            Console.WriteLine("PRINT NUMBERS");

            int[] numberList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22};
            
            int indexOffset = 5;
            int rangeCount = 3;
            ArraySegment<int> ArraySegmentRangeNumber = new ArraySegment<int>(numberList,indexOffset, rangeCount);
            
            
            int countElement = ArraySegmentRangeNumber.Count;
            int getNumberOffset = ArraySegmentRangeNumber.Offset;


            foreach(int number in ArraySegmentRangeNumber){
                Console.WriteLine(number);
            }

            // convert to array
            int[] arrayConvert = ArraySegmentRangeNumber.ToArray();

            
        }
        private void PrintArraySegmentExampleOffset(ArraySegment<DesignPatterns> array){
            foreach(DesignPatterns designPattern in array){
                Console.WriteLine("Id: {0} Name: {1} Group: {2}", designPattern.Id, designPattern.Name, designPattern.Group);
            }
        }
    }
}
