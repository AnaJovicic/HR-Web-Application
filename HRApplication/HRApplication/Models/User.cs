using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplication.Models
{
    public class User
    {
        private string name;
        private string surname;
        private string city;
        private string country;
        private string changeLocation; //string?
        private string fullOrPartTime; //bool ako je full, u suprotnom part.
        private string workExperience;
        private string historyOfJobs;
        private string keywords;      

        //private string Status;
        //private DateTime DateOfBirth;
        //private string Sex;
        //private string NoteField;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int UserId { get; set; }

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

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
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

        public string ChangeLocation
        {
            get
            {
                return changeLocation;
            }

            set
            {
                changeLocation = value;
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

        public string WorkExperience
        {
            get
            {
                return workExperience;
            }

            set
            {
                workExperience = value;
            }
        }

        public string HistoryOfJobs
        {
            get
            {
                return historyOfJobs;
            }

            set
            {
                historyOfJobs = value;
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
