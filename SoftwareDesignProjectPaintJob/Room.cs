using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SoftwareDesignProjectPaintJob
{
    public class Item
    {
        public string ItemName { get; set; }
        public decimal ItemColor { get; set; }
        public decimal ItemLength { get; set; }
        public decimal ItemWidthHeight { get; set; }
        public decimal ItemSF { get; set; }


        public Item(string inItemName, decimal inItemColor, decimal inItemLength, decimal inItemWidthHeight, decimal inItemSF)
        {
            ItemName = inItemName;
            ItemColor = inItemColor;
            ItemLength = inItemLength;
            ItemWidthHeight = inItemWidthHeight;
            ItemSF = inItemSF;
        }


    }

    public class Ceilings : Item
    {
        public Ceilings(string inItemName, decimal inItemColor, decimal inItemLength, decimal inItemWidthHeight, decimal inItemSF) : base(inItemName, inItemColor, inItemLength, inItemWidthHeight, inItemSF)
        {
        }
    }

    public class item_class : IItemEstInterface
    {
        public decimal itemEstTotal;
        public void doCalc(decimal itemPaintColors, decimal itemLength, decimal itemWidthHeight, decimal itemRate)
        {
            decimal l, w, r;
            l = itemLength;
            w = itemWidthHeight;
            r = itemRate;
            itemEstTotal = l * w * r;
        }
    }


}


