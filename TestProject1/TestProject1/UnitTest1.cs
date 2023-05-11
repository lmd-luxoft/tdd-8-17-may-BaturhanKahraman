using TDDKata;
using Xunit.Sdk;

namespace TestProject1
{
    public class UnitTest1
    {

        /*
         Create a simple String calculator with a method int Add(string numbers)
        The method can take 0, 1 or 2 numbers, and will return their sum 
        (for an empty string it will return 0) for example “” or “1” or “1,2”
        Start with the simplest test case of an empty string and move to 1 and 2 numbers
        Remember to solve things as simply as possible so that you force yourself 
        to write tests you did not think about
        Remember to refactor  after each passing test

         */
        [Fact]
        public void CalcShouldReturnZeroWhenEmptyString()
        {
            //arrange
            string emptyString = string.Empty;
            int expected = 0;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(emptyString);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CalcShouldReturnMinusOneWhenOnlyComma()
        {
            //arrange
            string emptyString = ",";
            int expected = -1;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(emptyString);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CalcShouldReturnMinusOneWhenNullString()
        {
            //arrange
            string nullString = null!;
            int expected = -1;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(nullString);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CalcShouldReturnMinusOneWhenDigitsNotIncludeComma()
        {
            //arrange
            string noCommaString = "123";
            int expected = -1;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(noCommaString);
            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void CalcShouldReturnMinusOneWhenDigitsNotADigit()
        {
            //arrange
            string notDigitString = "abc";
            int expected = -1;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(notDigitString);
            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void CalcShouldReturnSumSingleNumber()
        {
            //arrange
            string singleNumberString = "3";
            int expected = 3;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(singleNumberString);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CalcShouldReturnSumMultipleNumbers()
        {
            //arrange
            string multipleNumberString = "3,5";
            int expected = 8;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(multipleNumberString);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CalcShouldReturnMinusOneWhenStartsWithComma()
        {
            //arrange
            string multipleNumberString = ",3,5";
            int expected = -1;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(multipleNumberString);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CalcShouldReturnMinusOneWhenEndsWithComma()
        {
            //arrange
            string multipleNumberString = "3,5,";
            int expected = -1;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(multipleNumberString);
            //assert
            Assert.Equal(expected,actual);
        }
        /*
         Allow the Add method to handle new lines between numbers (instead of commas)
the following input is ok:  “1\n2,3”  (will equal 6)
the following input is NOT ok:  “1,\n”
         */
        [Fact]
        public void CalcCanIncludeNewLineInsteadOfCommas()
        {
            //arrange
            string newLinedString ="1\n2,3";
            int expected = 6;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(newLinedString);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CalcShouldReturnMinusOneWhenEndsWithNewLine()
        {
            //arrange
            string newLinedString = "1\n2,3\n";
            int expected = -1;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(newLinedString);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CalcShouldReturnMinusOneWhenStartsWithNewLine()
        {
            //arrange
            string newLinedString = "\n1,\n";
            int expected = -1;
            var calc = new Calc();
            //act
            var actual = calc.Calculate(newLinedString);
            //assert
            Assert.Equal(expected,actual);
        }
    }
}