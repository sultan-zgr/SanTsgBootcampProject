using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSearch.Domain.Entities
{
    public class Hotels
    {
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public string Features { get; set; }
        public string Description { get; set; }
        public string Availability { get; set; }
        public string RoomType { get; set; }
        public bool Evaluation { get; set; }
    }
}
