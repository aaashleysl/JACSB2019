﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using JACSBcafg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACSBcafg.Tests
{
    [TestClass()]
    public class SearchTests
    {
        [TestMethod()]
        public void BtnSearch_ClickTest()
        {
            string[] expectedSearchStrings = { "C++", "Java", "Python" };
            Assert.That(expectedSearchStrings, "@searchCriteria");
        }
    }
}
