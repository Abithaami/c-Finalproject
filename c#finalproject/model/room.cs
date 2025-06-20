using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_finalproject.model
{
    public class room
    {
        public string RoomID { get; set; }
        
        public string RoomType { get; set; }

        public room() { }

        public room(string roomId, string roomType)
        {
            RoomID = roomId;
            RoomType = roomType;
        }
    }
}
