using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      // arrange - gathering, declaring and/or creating necessary components for the
      // test. like when we create our description and newItems in the
      // test above
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      // act
      string result = newItem.GetDescription();

      // asset
      Assert.AreEqual(description, result);
    }

  }
}
