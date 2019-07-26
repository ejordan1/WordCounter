
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests{

[TestClass]
    public class FrequencyTest
    {
        [TestMethod]
        public void Frequency_NumberofAppearances_int()
        {   
            
            int result = Counter.WordFrequency("hello hello");
            Assert.AreEqual(result, 3);
        }
    }
}