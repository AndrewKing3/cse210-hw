using System.Data;

class Menu
{
    private int _bCount;
    private int _rCount;
    private int _lCount;

    public Menu()
    {
        _bCount = 0;
        _rCount = 0;
        _lCount = 0;
    }

    public void UpdateCount(int b, int r, int l)
    {
        _bCount = _bCount + b;
        _rCount = _rCount + r;
        _lCount = _lCount + l;
    }


    public int ProcessMenu()
    {
        int input = 0;

        while (input < 1 || input > 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"  1. Start breathing activity ({_bCount} seconds done recently)");
            Console.WriteLine($"  2. Start reflecting activity ({_rCount} seconds done recently)");
            Console.WriteLine($"  3. Start listing activity ({_lCount} seconds done recently)");
            Console.WriteLine($"  4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}