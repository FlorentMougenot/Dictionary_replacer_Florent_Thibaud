using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using DictionaryReplacer.Bibliotheque;

namespace DictionaryReplacer.Tests
{
    public class DictionaryReplacerTest
    {
        [Fact]
        public void TestEmptyString()
        {
            //arrange
            var dictionary = new Dictionary<string, string>();
            var replacer = new DictionaryReplacer.Bibliotheque.DictionaryReplacer();
            var stringInput = "";

            //Act
            string result = replacer.Replace(stringInput, dictionary);

            // Assert
            Assert.Equal("", result);
        }
    }
}
