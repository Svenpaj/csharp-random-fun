namespace App;

class Item
{
    public string Name;
    public int Att;
    public int Speed;
    public int Block;

    public Item(string name, int att, int speed, int block)
    {
        Name = name;
        Att = att;
        Speed = speed;
        Block = block;
    }


    public void Display()
    {
        Console.WriteLine($"\n**Displaying item: {Name}**\nName: {Name}\nAtt: {Att}\nSpeed: {Speed}\nBlock Power: {Block}");
    }
}
