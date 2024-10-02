﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //indicates Id will be auto generated 
        /*Here's what it means in detail:

        DatabaseGenerated: This attribute is used to configure how the value of a particular property is generated in the database.
        DatabaseGeneratedOption.Identity: This specific option indicates that the value for the property will be generated by the database when a new row (or entity) is inserted. It's typically used for primary key fields that are auto-incremented by the database, such as Id fields in SQL databases.
        In your case, it means that the Id field will not be set manually by the application. Instead, the database will automatically assign an incremented value for each new User record.*/
        public int Id { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string AddressFirstLine { get; set; }

        public string AddressSecondLine { get; set; }

        public string AddressCity { get; set; }

        public string PostCode { get; set; }

    }
}
