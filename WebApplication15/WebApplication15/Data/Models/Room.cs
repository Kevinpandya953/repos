using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class Room
    {
        public Room()
        {
            SemesterCourse = new HashSet<SemesterCourse>();
        }

        public int RoomId { get; set; }
        public int BuildingId { get; set; }
        public string RoomName { get; set; }
        public bool IsLibrary { get; set; }
        public bool IsComputerLab { get; set; }
        public bool IsOtherLab { get; set; }
        public int Capacity { get; set; }

        public virtual Building Building { get; set; }
        public virtual ICollection<SemesterCourse> SemesterCourse { get; set; }
    }
}
