using System;

namespace GamesClasses
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public int AccountId { get; set; }
        public DateTime DateHired { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public bool StaffAdmin { get; set; }
    }
}