using System.Runtime.CompilerServices;

class Police : Person
{
    private String _weapon;
    public Police(string firstName, string lastName, int age, double weight, string weapon) : base(firstName, lastName, age, weight)
    {
        _weapon = weapon;
    }

    public override string GetPersonInfo()
    {
        return $"Police: weapon: {_weapon}: {base.GetPersonInfo()}";
    }
}