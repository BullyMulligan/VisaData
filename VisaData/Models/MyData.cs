public class MyData
{
    public FullName full_name { get; set; }
    public string second_name { get; set; }
    public int marital_status { get; set; }
    public BirthDate birth_date { get; set; }
    public string birth_sity { get; set; }
    public string birth_country { get; set; }
    public Sitizenship sitizenship{ get; set; }


    public class Sitizenship
    {
        public string sitizenship{ get; set; }
        public bool second_sitizenship{ get; set; }
        public bool second_passport_availability{ get; set; }
        public string number_second_passport{ get; set; }
        public bool permanent_resident{ get; set; }
        public string second_country{ get; set; }

        public Sitizenship(string sitizenShip, bool secondSitizenship, bool secondPassportAvailability,
            string numberSecondPassport, bool permanentResident, string secondCountry)
        {
            sitizenship = sitizenShip;
            second_sitizenship = secondSitizenship;
            second_passport_availability = secondPassportAvailability;
            number_second_passport = numberSecondPassport;
            permanent_resident = permanentResident;
            second_country = secondCountry;
        }

    }

    public class FullName
    {
        public string name { get; set; }
        public string surnname { get; set; }
        public string fathername { get; set; }

        public FullName(string firstName, string SecondName, string FatherName)
        {
            name = firstName;
            surnname = SecondName;
            fathername = FatherName;
        }
        
    }
    public class BirthDate
    {
        public int birth_day { get; set; }
        public int birth_month { get; set; }
        public int birth_year { get; set; }

        public BirthDate(int day, int month, int year)
        {
            birth_day = day;
            birth_month = month;
            birth_year = year;
        }
    }
}
