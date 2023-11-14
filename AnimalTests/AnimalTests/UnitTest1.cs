using MyInheritanceLibrary;
namespace AnimalTests 
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void Speak_Bark()
        {
            //arrange
            var expectedwoof = "bark bark";
            var actualwoof = new string(expectedwoof);
            //act

            //assert
            Assert.AreEqual(expectedwoof, actualwoof);
        }
        [TestMethod]
        public void Speak_Meow()
        {
            //arrange
            var expectedmeow = "meow meow";
            var actualmeow = new string(expectedmeow);
            //act
            //assert
            Assert.AreEqual(expectedmeow, actualmeow);
        }
        [TestMethod]
        
        public void Speak_Chirp()
        {
            //arrange
            var expectedchirp = "chirp chirp";
            var actualchirp = new string(expectedchirp);
            //act
            //assert
            Assert.AreEqual(expectedchirp, actualchirp);
        }
    }
}