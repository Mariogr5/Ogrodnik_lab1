using Ogrodnik_lab1;
using System.Security.Cryptography.X509Certificates;

namespace BagpackTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCountElements()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
            {
                Problem problem = new Problem(n, 1);
                Assert.AreEqual(n, problem.problemItems.Count());

            }
        }

        [TestMethod]
        public void TestMethodReturnElements()
        {
            int capacity = 20;

            var problem = new Problem(20, 1);
            var result = problem.Solve(capacity);
            foreach (var item in problem.problemItems)
            {
                if (item.Weight <= capacity)
                {
                    Assert.AreNotEqual("", result.ToString());
                }
            }
        }
        [TestMethod]
        public void TestMethodNotReturnElements()
        {
            int capacity = 0;
            var problem = new Problem(20, 1);
            var result = problem.Solve(capacity);
            Assert.AreEqual("", result.ToString());

        }
        [TestMethod]
        public void TestMethodOrderElements()
        {
            int capacity = 20;
            var problem = new Problem(20, 1);
            var result = problem.Solve(capacity);

            problem.problemItems.Reverse();

            var secondResult = problem.Solve(capacity);

            Assert.AreEqual(result.summaricPrize, secondResult.summaricPrize);
        }

        [TestMethod]
        public void TestCorrectAnswers()
        {
            int testWeight = 6;
            var problem = new Problem(17, 1);
            var correctItems = new List<Item>() { new Item(1, 50, problem.problemItems.Count), new Item(2, 50, problem.problemItems.Count + 1),
                new Item(3, 50, problem.problemItems.Count + 2) };

            problem.problemItems.AddRange(correctItems);
            var result = problem.Solve(testWeight);
            CollectionAssert.AreEqual(result.Items, correctItems);
        }

        [TestMethod]
        public void TestTotalWeightofItems()
        {
            var testWeight = new List<int>() { 1, 2, 3, 4, 5, 10, 15, 20 };
            foreach (var weight in testWeight)
            {
                var problem = new Problem(20, 1);
                var result = problem.Solve(weight);
                Assert.IsTrue(result.summaricWeight <= weight);
            }
        }

        [TestMethod]
        public void TestRandomSeed()
        {
            int capacity = 20;
            var problem = new Problem(20, 1);
            var secondProblem = new Problem(20, 1);

            CollectionAssert.AreEqual(problem.problemItems, problem.problemItems);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            int capacity = 20;
            var problem = new Problem(20, 1);
            var result = problem.Solve(capacity);

            if (result.Items.Count >= 1)
                Assert.IsFalse(string.IsNullOrEmpty(result.ToString()));
            else
                Assert.IsTrue(string.IsNullOrEmpty(result.ToString()));
        }


        [TestMethod]
        public void TestIfGoodObjectisCreated()
        {
            int capacity = 20;
            var problem = new Problem(20, 1);
            var result = problem.Solve(capacity);

            Assert.AreEqual(result.GetType(), typeof(Result));
        }
        [TestMethod]
        public void TestIfItemsHaveOwnNumbers()
        {
            var problem = new Problem(20, 1);
      
            foreach(var item in problem.problemItems)
            {
                foreach(var secondItem in problem.problemItems)
                {
                    if(secondItem != item)
                        Assert.IsFalse(item.Number == secondItem.Number);
                }
            }
        }

    }
}