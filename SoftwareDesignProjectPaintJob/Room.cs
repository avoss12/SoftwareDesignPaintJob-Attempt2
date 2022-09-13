using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignProjectPaintJob
{
    public class Room
    {
        public string RoomName { get; set; }
        public string RoomColor { get; set; }
        public decimal RoomLength { get; set; }
        public decimal RoomWidth { get; set; }
        public decimal RoomSF { get; set; }


        public Room(string inRoomName, string inRoomColor, decimal inRoomLength, decimal inRoomWidth, decimal inRoomSF)
        {
            RoomName = inRoomName;
            RoomColor = inRoomColor;
            RoomLength = inRoomLength;
            RoomWidth = inRoomWidth;
            RoomSF = inRoomSF;
        }


    }

    public class Ceilings : Room
    {
        public Ceilings(string inRoomName, string inRoomColor, decimal inRoomLength, decimal inRoomWidth, decimal inRoomSF) : base(inRoomName, inRoomColor, inRoomLength, inRoomWidth, inRoomSF)
        {
        }
    }
}            

       
