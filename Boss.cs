namespace App;

class Boss 
{
    public string Name;
    public string Lore = "The most insanly strong boss, you have never encountered something like this before..";
    public int Hp;
    public int Att;
    public string Loot;
    public string Sound;

    public Boss(string name, int hp, int att, string loot, string sound)
    {
        Name = name;
        Hp = hp;
        Att = att;
        Loot = loot;
        Sound = sound;
    }

    public void Present()
    {
        Console.WriteLine($"*** Boss: {Name} appears! ***");
        Console.WriteLine($"** Lore:\n{Lore} ***");

        if(Loot != "")
        {
            Console.WriteLine("This boss is worth killing, you can clearly see something awesome shining from within its body! (Clearly loot stupid..)");
        }
        else
        {
            Console.WriteLine("This boss has no loot. You should just leave it roaring and continue looking");
        }
    }

    public void MakeSound()
    {
        Console.WriteLine(Sound);
    }
}
