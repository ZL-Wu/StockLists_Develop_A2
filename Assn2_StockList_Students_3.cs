using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {
        //param        : NA
        //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
        //return       : total value
        //return type  : decimal
        public decimal Value()
        {
            //if value = 0.0, excutive stocknode
            decimal value = 0.0m;
            StockNode current = this.head;
            //traverse the loop till the end, return the total value as a decimal
            while (current != null)
            {
                decimal currentholdings = current.StockHolding.Holdings;
                decimal currentprices = current.StockHolding.CurrentPrice;
                value += currentholdings * currentprices;
                current = current.Next;
            }
            return value;
        }
        //param  (StockList) listToCompare     : StockList which has to comared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;
            StockNode currentone = this.head;
            StockNode currenttwo = listToCompare.head;
            while (currentone != null)
            {
                while (currenttwo != null)
                {
                    string currentname = currentone.StockHolding.Name;
                    string comparename = currenttwo.StockHolding.Name;
                    if (currentname.CompareTo(comparename) == 0)
                        similarityIndex++;
                    currenttwo = currenttwo.Next;
                }
                currenttwo = listToCompare.head;
                currentone = currentone.Next;
            }

            return similarityIndex;
        }

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            StockNode current = this.head;
            while (current != null)
            {
                Console.WriteLine(current.StockHolding.ToString());
                current = current.Next;
            }
        }
    }
}
