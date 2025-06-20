using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_finalproject.model
{
    public class rooms
    {
        public string RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }

        public rooms() { }

        public rooms(string roomID, string roomName, string roomType)
        {
            RoomID = roomID;
            RoomName = roomName;
            RoomType = roomType;
        }
    }
}
