using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description {get; set;}
    public static List<Item> _instances {get;set;} = new List<Item> {}; //new static variable

    public Item(string description)
    {
      Description = description;
      _instances.Add(this); //pushes 'this' to the list automatically on creation!
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }
    public static void ClearsAll()
    {
      _instances.Clear();
    }
  }
}