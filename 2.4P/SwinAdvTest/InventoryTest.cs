using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SwinAdv;

namespace SwinAdvTest
{
    public class TestInventory
    {
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");


        [SetUp]
        public void Setup()
        {

        }

        
        [Test]
        public void TestFindItem()
        {
            
            Inventory inventory = new Inventory();
            inventory.Put(shovel);

            bool itemFound = inventory.HasItem(shovel.FirstId);

            Assert.That(itemFound, Is.True);
        }


        [Test]
        public void TestNoFindItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Assert.IsFalse(i.HasItem(sword.FirstId));
        }

        [Test]
        public void TestFetchItems()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Item fetchItem = i.Fetch(shovel.FirstId);

            Assert.IsTrue(fetchItem == shovel);
            Assert.IsTrue(i.HasItem(shovel.FirstId));
        }

        [Test]
        public void TestTakenItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            i.Take(shovel.FirstId);
            Assert.IsFalse(i.HasItem(shovel.FirstId));
        }

        [Test]
        public void TestItemList()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            i.Put(sword);
            Assert.IsTrue(i.HasItem(shovel.FirstId));
            Assert.IsTrue(i.HasItem(sword.FirstId));

            string expctOutput = "a shovel (shovel)\n" + "a sword (sword)\n";
            Assert.AreEqual(i.ItemList, expctOutput);
        }

    }
}