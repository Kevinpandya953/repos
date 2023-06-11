using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class Building
    {
        public Building()
        {
            Room = new HashSet<Room>();
        }

        public int BuildingId { get; set; }
        public int CampusId { get; set; }
        public string BuildingName { get; set; }
        public int NoOfRooms { get; set; }
        public int NoOfMeetingHalls { get; set; }
        public bool IsLibrary { get; set; }
        public int NoOfComputerLabs { get; set; }
        public int NoOfTerminals { get; set; }

        public virtual Campus Campus { get; set; }
        public virtual ICollection<Room> Room { get; set; }
    }
}
