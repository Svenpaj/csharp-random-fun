namespace App;
class Hero 
{
    public string Name;
    public int Hp;
    public int Att;
    public Item[] Items;

    public Hero(string name) 
    {
        Name = name;
        Hp = 100;
        Att = 50;
        Items = new Item[20];
    }

    public void Stats()
    {
        Console.WriteLine("Name: " + Name + "\nHP: " + Hp + "\nATT: " + Att + "\nInventory: ");
        Inventory();
    }
    
    public void Inventory()
    {
        int current_item = 1;
        Console.WriteLine("**INVENTORY**\n");
        foreach(Item item in Items)
        {
            if(item != null && item.Name != "")
            {
                Console.WriteLine($"{current_item}. {item.Name}");
            }
        }
    }

    public void AddItem(Item item)
    {
       for(int i = 0; i < 20; i += 1)
       {
           if(Items[i] == null)
           {
               Items[i] = item;
               break;
           }
       }
    }
}
