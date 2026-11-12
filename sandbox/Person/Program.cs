class Program
{
    
    public static void DisplayPersonInfo(Person person)
    {
        Console.WriteLine(person.GetPersonInfo());
    }


    public static void Main()
    {
        Person myPerson = new Person("John","Revelator",50, 190);
        //Console.WriteLine(myPerson.GetPersonInfo());


        Doctor myDoctor = new Doctor ("Bob", "Payne", 45, 279, "Knife");
       // Console.WriteLine(myDoctor.GetDoctorInfo());

        Police myPolice = new Police ("Gary", "Goodman", 61, 181, "Gun");
        //Console.WriteLine(myPolice.GetPoliceInfo());

        List<Person> myPeople  = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
            DisplayPersonInfo(person);   
        }

    }
}
