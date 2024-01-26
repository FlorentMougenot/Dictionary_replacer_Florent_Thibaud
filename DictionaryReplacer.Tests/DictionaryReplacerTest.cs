using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using DictionaryReplacer.Bibliotheque;
using Newtonsoft.Json.Linq;

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

        [Fact]
        public void TestEmptyDictionary()
        {
            //arrange
            var dictionary = new Dictionary<string, string>();
            var replacer = new DictionaryReplacer.Bibliotheque.DictionaryReplacer();
            var stringInput = "a";

            //Act
            string result = replacer.Replace(stringInput, dictionary);

            // Assert
            Assert.Equal("a", result);
        }

        [Fact]
        public void TestReplaceCorrectOn1Word()
        {
            //arrange
            var dictionary = new Dictionary<string, string>
        {
            { "Floflo", "PetiteuhFleur" }
        };
            var replacer = new DictionaryReplacer.Bibliotheque.DictionaryReplacer();
            var stringInput = "$Floflo$";

            //Act
            string result = replacer.Replace(stringInput, dictionary);

            // Assert
            Assert.Equal("PetiteuhFleur", result);
        }

        [Fact]
        public void TestWordNotInDictionary()
        {
            //arrange
            var dictionary = new Dictionary<string, string>
        {
            { "Floflo", "PetiteuhFleur" }
        };
            var replacer = new DictionaryReplacer.Bibliotheque.DictionaryReplacer();
            var stringInput = "$a$";

            //Act
            string result = replacer.Replace(stringInput, dictionary);

            // Assert
            Assert.Equal("$a$", result);
        }
    }
}
