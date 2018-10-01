using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {

        //param   (StockList)listToMerge : second list to be merged 
        //summary      : merge two different list into a single result list
        //return       : merged list
        //return type  : StockList
        public StockList MergeList(StockList listToMerge)
        {
            StockList mergedList = new StockList();
            StockNode currentOne = this.head;
            StockNode currentTwo = listToMerge.head;
            // traverse the first list till the end and add the nodes to merged list
            while (currentOne != null)
            {
                mergedList.AddStock(currentOne.StockHolding);
                currentOne = currentOne.Next;
            }
            // traverse the second list till the end, also add the nodes to merged list
            while (currentTwo != null)
            {
                mergedList.AddStock(currentTwo.StockHolding);
                currentTwo = currentTwo.Next;
            }

            return mergedList;
        }

        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public Stock MostShares()
        {
            // when stocklist is empty 
            if (this.IsEmpty())
                return new Stock();
            Stock mostShareStock = new Stock();
            StockNode current = this.head;
            StockNode most = this.head;
            // traverse the list till the end
            while (current != null)
            {
                // start with class StockNode, get access of class Stock to get the value of currentHoldings
                decimal currentHoldings = current.StockHolding.Holdings;
                decimal mostHoldings = most.StockHolding.Holdings;
                // compare currentHoldings and mostHodings to find the stock with most of number of holdings
                if (currentHoldings > mostHoldings)
                    most = current;
                current = current.Next;
            }
            mostShareStock = most.StockHolding;
            return mostShareStock;
        }

        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {
            int length = 0;
            StockNode current = this.head;
            //traverse the list till the end, return the length to find the number of presented notes
            while (current != null)
            {
                current = current.Next;
                length++;
            }
            return length;
        }
    }
}
