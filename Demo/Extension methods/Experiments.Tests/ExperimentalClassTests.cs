using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Experiments.Tests
{
    [TestClass]
    public class ExperimentalClassTests
    {
        [TestMethod]
        public void IsNullOrEmpty_Hello_World_returned_true()
        {
            //arrange
            String str = "Hello World";
            bool expected = true;
            bool actual;

            //act           
            ////StringExtension s = new StringExtension();
            ////bool actual = str.IsNullOrEmpty(s);
            /*(здесь я пытался не прописывать с самого начала метод 
            а закинуть эти данные в метод который находится в библиотеке классов,
           то есть я пытался сделать тоже самое что написано в видео, также подключил StringExtension в зависимость
           к Experiments.Tests, но он выдаёт ошибку, что нельзя использовать в данном контексте название этого класса)*/

            if (str == null || str.Length == 0)
            {
                actual = false;
            }
            else
            {
                actual = true;
            }
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsDateTimeTest_EnteredStringWithDate_TheSameDateReturned()
        {
            // Arrange
            String str = "2018.8.29.22.11.30";
            Char flag = '.';
            DateTime expectedDate = new DateTime(2018, 8, 29, 22, 11, 30);

            // Act
            String[] substrings = str.Split(flag);
            int year = Convert.ToInt32(substrings[0]);
            int month = Convert.ToInt32(substrings[1]);
            int day = Convert.ToInt32(substrings[2]);
            int hour = Convert.ToInt32(substrings[3]);
            int minute = Convert.ToInt32(substrings[4]);
            int second = Convert.ToInt32(substrings[5]);
            DateTime actualDate = new DateTime(year, month, day, hour, minute, second);

            // Assert
            Assert.AreEqual(expectedDate, actualDate);

        }        
    }
}
