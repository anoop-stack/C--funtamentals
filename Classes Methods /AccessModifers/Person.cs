using System;

namespace AccessModifers
{
    public class Person
    {


        /*------------------------------------------------------------------------------------------------*/
        private string _name1;
        public string Get_name()
        {
            return _name1;
        }
        public void Set_name(string value)
        {
            _name1 = value;
        }

        /*------------------------------------------------------------------------------------------------*/


        private DateTime _birthday;


        // converting it into property , this way we can put condtn before set or set 
        public DateTime Birthday
        {
            // get => _birthday;
            get
            {
                // DateTime dateTime = new DateTime();
                // DateTime newBirth = dateTime;
                // if (!string.IsNullOrEmpty(Convert.ToString(_birthday)))
                // {
                //     return new DateTime();
                // }
                return _birthday;
            }
            set => _birthday = value;
        }

        /*------------------------------------------------------------------------------------------------*/

        //auto implemented property
        // equivalent ot above code
        public int Number { get; set; } // compiler generate private field for number
    }
}
