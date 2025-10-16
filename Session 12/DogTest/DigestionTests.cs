using WpfApp1;

namespace DogTest {
    [TestClass]
    public sealed class DigestionTests {
        [TestMethod]
        public void TestDogDigestion() {
            Dog dog = new Dog();
            dog.Feed("Double Batman");
            Assert.IsFalse(dog.IsHungry);
            Thread.Sleep(2000);
            Assert.IsTrue(dog.IsHungry);
        }

        [TestMethod]
        public void TestSnakeDigestion() {
            Snake gerald = new Snake();
            gerald.Feed("Triple Batman");
            Assert.IsFalse(gerald.IsHungry);
            Thread.Sleep(2000);
            Assert.IsFalse(gerald.IsHungry);
        }
    }
}
