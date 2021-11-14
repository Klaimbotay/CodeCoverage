using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class MainTests
    {
        [Fact]
        public void ShouldRunConsole()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var userIputString = new string[5]
            {
                "1", "1", "a", "n", ""
            };

            var text = string.Join(Environment.NewLine, userIputString);
            var userInput = new StringReader(text);
            Console.SetIn(userInput);

            Program.Main(new string[0]);

            var expectedResult = new string[11]
            {
                "Console Calculator in C#\r", "------------------------\n", "Type a number, and then press Enter: Type another number, and then press Enter: Choose an operator from the following list:",
                "\ta - Add", "\ts - Subtract", "\tm - Multiply", "\td - Divide", "Your option? Your result: 2\n", "------------------------\n", "Press 'n' and Enter to close the app, or press any other key and Enter to continue: \n",
                ""
            };

            var result = stringWriter.ToString().Split(Environment.NewLine);
            Assert.Equal(expectedResult, result);
        }
    }
}
