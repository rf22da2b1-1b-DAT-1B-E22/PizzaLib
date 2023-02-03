using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model.Tests
{
    [TestClass()]
    public class PizzaTests
    {

        /*
         * ID
         */
        [TestMethod()]
        [DataRow(0)]
        [DataRow(6)]
        public void PizzaIdOKTest(int value)
        {
            // arrange
            Pizza pizza= new Pizza();
            int expectedId = value;

            // act
            pizza.Id = value;
            int actualId = pizza.Id;


            //assert
            Assert.AreEqual(expectedId, actualId);
        }

        [TestMethod()]
        [DataRow(-1)]
        [DataRow(-6)]
        public void PizzaIdFailTest(int value)
        {
            // arrange
            Pizza pizza = new Pizza();

            // act + assert
            Assert.ThrowsException<ArgumentException>(
                // act
                () => pizza.Id = value
                );
        }

        [TestMethod()]
        [DataRow("12345")]
        [DataRow("Det er bare sjovt")]
        public void PizzaNameOkTest(String value)
        {
            // arrange
            Pizza pizza = new Pizza();
            string expectedName = value;

            //act
            pizza.Name = value;
            String actualName = pizza.Name;


            //assert
            Assert.AreEqual(expectedName, actualName);
        }

        [TestMethod()]
        [DataRow("1234")]
        [DataRow("          ")]
        public void PizzaNameFailTest(String value)
        {
            // arrange
            Pizza pizza = new Pizza();
            
            //act + assert
            Assert.ThrowsException<ArgumentException>(() => pizza.Name = value);
        }

        [TestMethod()]
        [DataRow(null)]
        public void PizzaNameFail2Test(String value)
        {
            // arrange
            Pizza pizza = new Pizza();

            //act + assert
            Assert.ThrowsException<ArgumentNullException>(() => pizza.Name = value);
        }

        [TestMethod()]
        public void PizzaConstructorFailTest()
        {
            // arrange
            

            //act + assert
            Assert.ThrowsException<ArgumentException>(() => new Pizza(-1, "petre", 44));
        }

    }
}