using System;
using System.Linq;
using Example_ArraySegment.Entities;

namespace Example_ArraySegment.ExampleArraySegment
{
    public class ArraySegmentDesignPattern
    {
         DesignPatterns[] designPatterns = {
                new DesignPatterns("Abstract Factory", GroupPatterns.Creational),
                new DesignPatterns("Builder", GroupPatterns.Creational),
                new DesignPatterns("Observer", GroupPatterns.Behavioral),
                new DesignPatterns("Strategy", GroupPatterns.Behavioral),
                new DesignPatterns("Proxy", GroupPatterns.Structural),
                new DesignPatterns("Adapter", GroupPatterns.Structural)
                };

        public void PrintAllPatterns(){
            Console.WriteLine("Print all patterns:");
            PrintArraySegmentExampleOffset(designPatterns,0,designPatterns.Length);
        }
        
        public void PrintRangePatternCreational(){
            Console.WriteLine("Print Creational patterns:");
            PrintArraySegmentExampleOffset(designPatterns,0,2);
        }
        public void PrintRangePatternStructural(){
            Console.WriteLine("Print Structural patterns:");
            PrintArraySegmentExampleOffset(designPatterns,2,2);
        }

        public void PrintRangePatternBehavioral(){
            Console.WriteLine("Print Behavioral patterns:");
            PrintArraySegmentExampleOffset(designPatterns,4,2);
        }
        private void PrintArraySegmentExampleOffset(DesignPatterns[] designPatterns,
                                                    int indexOffset, int langhtRange){

            ArraySegment<DesignPatterns> ArraySegmentDesignPatterns = 
                new ArraySegment<DesignPatterns>(designPatterns, indexOffset, langhtRange);

            foreach(DesignPatterns designPattern in ArraySegmentDesignPatterns){
                Console.WriteLine("Id: {0} Name: {1} Group: {2}", designPattern.Id, designPattern.Name, designPattern.Group);
            }
            Console.WriteLine("\n");
        }

        public void GetListPatternsWichoSlice(int index){
            Console.WriteLine();
            Console.WriteLine("Print example, with method Slice<t>");
            ArraySegment<DesignPatterns> ArraySegmentDesignPatternsInsert = 
                new ArraySegment<DesignPatterns>(designPatterns);

            var t = ArraySegmentDesignPatternsInsert.Slice(index);

            foreach(DesignPatterns value in t){
                Console.WriteLine(value.Name);
            }
        }
        public void GetListPatternsWichoSlice(int index, int count ){
            Console.WriteLine();
            Console.WriteLine("Print example, with method Slice<t>");
            ArraySegment<DesignPatterns> ArraySegmentDesignPatternsInsert = 
                new ArraySegment<DesignPatterns>(designPatterns);

            var t = ArraySegmentDesignPatternsInsert.Slice(index, count);

            foreach(DesignPatterns value in t){
                Console.WriteLine(value.Name);
            }
        }
        public void CountGroupPatternsLinq(){
            
            ArraySegment<DesignPatterns> ArraySegmentDesignPatterns = 
                new ArraySegment<DesignPatterns>(designPatterns);

            Console.WriteLine("Print all patterns:");
            var patternsAll = ArraySegmentDesignPatterns.GroupBy(
                    pattern => pattern.Group, (patternName, patternGroup) => new {
                        Key = patternName, Count = patternGroup.Count()
                    });

            Console.WriteLine("Print creational patterns with link:");
            foreach(var design in patternsAll){
                Console.WriteLine("Key: {0} Count: {1}", design.Key, design.Count);
            }
            
            Console.WriteLine("\n");
        }
    }
}