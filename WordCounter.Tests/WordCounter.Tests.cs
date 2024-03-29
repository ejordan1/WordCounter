
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests{

[TestClass]
    public class FrequencyTest
    {
        [TestMethod]
        public void Frequency_NumberofAppearances_3()
        {   
            
            int result = Counter.CountWordFrequency("hi","hi hi.hi.");
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void Frequency_NumberofAppearances_4()
        {   
            
            int result = Counter.CountWordFrequency("hi","a.hi.f.hit.hi.hi.hi.");
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void Frequency_NumberofAppearances_6()
        {   
            
            int result = Counter.CountWordFrequency("hi","h'i hi hi hi hi adfhi hi'");
            Assert.AreEqual(result, 6);
        }
    }
}