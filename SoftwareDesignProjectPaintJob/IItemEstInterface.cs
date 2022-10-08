using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignProjectPaintJob
{
    interface IItemEstInterface
    {
        void doCalc(decimal itemlength, decimal itemWidthHeight, decimal itemRate);
    }
    class item_class : ItemEstInterface
    {
        decimal itemEstTotal;
    }
    public void doCalc(decimal itemLength, decimal itemWidthHeight, decimal itemRate)
    {
        decimal l, w, r;
        l = itemLength;
        w = itemWidthHeight;
        r = itemRate;
        itemEstTotal = l * w * r;
    }
    class calc_interface
    {
        static void Main(string[] AssemblyLoadEventArgs)
        {
            item_class obj_item_iclass = new item_EstClass();
            object_item_iclass.doCalc(txtItemLength.Text)
        }
    }
    internal interface Interface1
    {
    }
}
