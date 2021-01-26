using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    // unknown 0
    // male 1
    // female 2

    public enum Session
    {
        Winter=1,
        Summer = 2,
        Spring=3
    }

    public enum Gender : short
    { 
        Unknown,
        Male,
        Female
    }
    class Person
    {
        public string name { get; set; }
        public Gender gender { get; set; }

        public string getGender(Gender gender) {

            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid";
            }
        }
        public short[] getValues(Gender gender) {

            short[] value = (short[])Enum.GetValues(typeof(Gender));
            return value;
        }

        public string[] getName(Gender gender) {
            string[] name = (string[])Enum.GetNames(typeof(Gender));
            return name;
        }
    }


}
