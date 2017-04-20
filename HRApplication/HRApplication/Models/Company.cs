using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplication.Models
{
    public class Company
    {
        private string name;
        private string description;
        private string city;
        private string country;
        private int phone;
        private string email;
        private string website;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int CompanyId { get; set; }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public int Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Website
        {
            get
            {
                return website;
            }

            set
            {
                website = value;
            }
        }




    }
}
