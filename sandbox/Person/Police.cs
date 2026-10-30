using System.Runtime.CompilerServices;

class Police : Person
{
    private String _weapon;
    public Police(string firstName, string lastName, int age, double weight, string weapon) : base(firstName, lastName, age, weight)
    {
        _weapon = weapon;
    }

    public string GetPoliceInfo()
    {
        return $"Police: weapon: {_weapon}: {GetPersonInfo()}";
    }
}