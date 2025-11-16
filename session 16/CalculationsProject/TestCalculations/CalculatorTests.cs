

namespace TestCalculations {
    [TestClass]
    public sealed class CalculatorTests {
        [TestMethod]
        public void TestAdd()
        {
            //Assert.AreEqual(12, Calculations.add2Numbers(5, 7));
        }
        [TestMethod]
        public void TestDivide() {
            Assert.AreEqual(2,Calculations.divide2Numbers(4, 2));
        }
        [TestMethod]
        public void TestDivide2() {
            Assert.AreEqual(5d / 7d, Calculations.divide2Numbers(5, 7),0.001);
        }
        [TestMethod]
        public void TestDivide3() {
            double result = Calculations.divide2Numbers(5, 7);
            double roundingError = result - ((5d / 7d));
            if (roundingError > 0.001) {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestDivide4() {
            double result = Calculations.divide2Numbers(5, 7);
            double roundingError = result - ((5d / 7d));
            if (roundingError > 0.001) {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestEqualityAndSameness() {
            Thing t1 = new Thing() { Name = "Derek" };
            Thing t2 = new Thing() { Name = "Derek" };
            Thing t3 = t1;
            Assert.IsTrue(t1 == t2);
            Assert.AreEqual(t1, t2);
            Assert.AreNotSame(t1, t2);
            Assert.AreSame(t1, t3);
        }
        [TestMethod]
        public void TestLessThanness() {
            Thing t1 = new Thing() { Name = "Derek" };
            Thing t2 = new Thing() { Name = "Ossie" };
            Assert.IsTrue(t1 <= t2);
        }

    }
    public class Thing {
        public string Name { get; set; }
        public override bool Equals(object? obj) {
            if (obj is Thing) {
                return Name == ((Thing)obj).Name;
            }
            return false;
        }
        public static bool operator == (Thing t1, Thing t2) {
            return t1.Equals(t2);
        }
        public static bool operator != (Thing t1, Thing t2) {
            return !t1.Equals(t2);
        }
        public static bool operator < (Thing t1, Thing t2) {
            return t1.Name.CompareTo(t2.Name) < 0;
        }
        public static bool operator > (Thing t1, Thing t2) {
            return t1.Name.CompareTo(t2.Name) < 0;
        }
        public static bool operator <=(Thing t1, Thing t2) {
            int res = t1.Name.CompareTo(t2.Name);
            return res == 0 || res < 0;
        }
        public static bool operator >=(Thing t1, Thing t2) {
            int res = t1.Name.CompareTo(t2.Name);
            return res == 0 || res > 0;
        }
    }
}
