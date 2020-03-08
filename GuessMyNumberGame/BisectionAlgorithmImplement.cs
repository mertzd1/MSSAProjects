using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace GuessMyNumberGame
{
    class BisectionAlgorithmImplement
    {
       
        private int[] Test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};
       
        public BisectionAlgorithmImplement()
        {

        }

        public BisectionAlgorithmImplement(  int[] test)
        {
           
            this.Test = test;
    
        }


        public int [] Check(int Value)
        {
 
            int Middle = Test.Length / 2;
            if (Value == Test[Middle])
            {
                int[] Temp = Test[Middle..(Middle + 1)]; //this takes the middle of the array I have to do Middle +1 because it is inclusive
                Test = Temp;
                return Test;
            }

            else if (Value > Test[Middle])
            {
                int[] Temp = Test[Middle..Test.Length]; //this copies the Test array from the middle to the end
                Test = Temp; //this takes the new value of the [] and assigns it back to test
                Test = Check(Value); //this recursively runs the test [] back through the algorithm

            }
            // putting Test[middle] sets the value to the middle position of the array, 
            //without Test[] the middle becomes a value and is tested against Value

             else if (Value < Test[Middle])
             {
                int[] Temp = Test[0..Middle]; //this copies the Test array from the 0 index to the middle
                Test = Temp;
                Test = Check(Value);
             }

           
            return Test;
        }
       
    }

   
}
