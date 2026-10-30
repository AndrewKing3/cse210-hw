using System.Runtime.CompilerServices;

class Doctor : Person
{
    private String _tools;
    public Doctor(string firstName, string lastName, int age, double weight, string tools) : base(firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    public string GetDoctorInfo()
    {
        return $"Doctor: Tools: {_tools}: {GetPersonInfo()}";
    }
}