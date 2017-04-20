using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplication.Models
{
    public class JobPosition
    {
        private string name;
        private string description;
        private string city;
        private string country;
        private string fullOrPartTime; //bool ako je full, u suprotnom part.
        private string keywords;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int JobId { get; set; }

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

        public string FullOrPartTime
        {
            get
            {
                return fullOrPartTime;
            }

            set
            {
                fullOrPartTime = value;
            }
        }

        public string Keywords
        {
            get
            {
                return keywords;
            }

            set
            {
                keywords = value;
            }
        }
    }
}
