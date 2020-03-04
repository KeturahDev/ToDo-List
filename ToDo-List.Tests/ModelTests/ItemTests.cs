using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearsAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arange
      string description = "Mow the lawn";
      Item newItem = new Item(description);
      //Act
      string result = newItem.Description;
      //Assert
      Assert.AreEqual(result, description);
    }
    [TestMethod]
    public void SetDescription_AlterDescriptionProperty_String()
    {
      //Arange
      string description = "mow the lawn";
      Item newItem = new Item(description);

      //Act
      string updateDescription = "mow the lawns";
      newItem.Description = updateDescription;
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(result, updateDescription);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arange
      List<Item> newList = new List<Item> {};

      //Act
      List<Item> result = Item.GetAll();

      // Assert
      CollectionAssert.AreEqual(result, newList);
    }
  }
}