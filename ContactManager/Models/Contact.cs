using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public enum PhoneTypeEnum
    {
        Home = 1,
        Work = 2,
        Mobile = 3
    }
    public class Contact
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneTypeEnum PhoneType { get; set; }
        public string Email { get; set; }
    }
}
