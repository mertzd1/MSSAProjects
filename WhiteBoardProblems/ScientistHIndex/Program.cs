using System;

namespace ScientistHIndex
{
    //The h-index is a metric used to measure the impact and productivity of a scientist or researcher.

        //A scientist has index h if h of their N papers have at least h citations each, and 
        // the other N-h papers have no more than h citations each. If there are multiple possible values 
        //for h, the maximum value is used.

        //Given an array of natural numbers, with each  value representing the number of citations
        //of a researcher's paper, return the h-index of that researcher.

        //For example, if the array was [4,1,0,2,3]

        //if 5 of the 5 papers have at least 5 ==false
        //if 4 of the 5 papers have at least 4 ==false
        //if 3 of the 5 papers have at least 3 ==false
        //if 2 of the 5 papers have at least 2==true
        //then 5-2 = 3 means that there are 3 with no more than 2

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int hIndex=CalculateHIndex(arr);
            Console.WriteLine(hIndex);

        }
        static int CalculateHIndex( int [] publicationCitations)        
        {

            int hIndex;      
            for(hIndex=publicationCitations.Length; hIndex>0;hIndex--)
            {
                int numpublicationsWithAtLeastHIndexCitations = 0;
                for(int x=0; x<publicationCitations.Length; x++)
                {
                    if(publicationCitations[x]>=hIndex)
                    {
                        numpublicationsWithAtLeastHIndexCitations++;
                    }
                }
                if (numpublicationsWithAtLeastHIndexCitations >= hIndex)
                    break;
                hIndex--;
            }
            return hIndex;

            
            
        }
    }
}
