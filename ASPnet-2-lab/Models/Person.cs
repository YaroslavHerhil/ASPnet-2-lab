namespace ASPnet_2_lab.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string fname, string lname, string shortdate)
        {
            FirstName = fname;
            LastName = lname;
            BirthDate = DateTime.Parse(shortdate);
        }
        public override string ToString() => FirstName + "/" + LastName + "/" + BirthDate.ToShortDateString() + "/";


    }
}
