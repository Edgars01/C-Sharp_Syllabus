using System.IO;
using System.Net.Mime;
using NUnit.Framework;

namespace Exercise5.Tests
{
    public class Tests
    {
        private IExercise _target;

        public string FileLocation = File.ReadAllText("../../../../Exercise5/TextFile.txt");
       

        [SetUp]
        public void Setup()
        {
            _target = new Exercise();
        }

        [Test]
        public void CharCountInFile_EmptyFile_ShouldFail()
        {
            //Assert
            Assert.Throws<System.IO.FileNotFoundException>(() => _target.CharCountInFile(null));
        }

        [Test]
        public void CharCountInFile_460CharsInFile_ShouldBeEqualToExpected()
        {
            //Assert
            Assert.AreEqual(460, _target.CharCountInFile(FileLocation));
        }

        [Test]
        public void WordCount_74WordsInFile_ShouldBeEqualToExpected()
        {
            //Assert
            Assert.AreEqual(74, _target.WordCount(FileLocation));
        }

        [Test]
        public void LineCount_8WordsInFile_ShouldBeEqualToExpected()
        {
            //Assert
            Assert.AreEqual(8, _target.LineCount(FileLocation));
        }
    }
}