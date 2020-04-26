using System;

namespace AccessModifers
{
    public class PropertyFunction
    {
        // if we only to set birthday once..  make set as private and set the value iin the constrcutor..
        public DateTime Birthday { get; private set; }
        public PropertyFunction(DateTime birthday)
        {
            Birthday = birthday;

        }



        public int Age
        {
            /*
            here it's a age , we only want to get the age based on birthday .. so there is no need of set.   
            */
            get
            {
                var time = DateTime.Now - Birthday;
                var year = time.Days / 365;

                return year;
            }
        }
    }
}
