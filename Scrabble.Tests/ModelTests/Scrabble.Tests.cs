using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {

    [TestMethod]
    public void
    {
      //Arange
      ScrabbleScoreCS newValue = new ScrabbleScoreCS();

      //Action
      var result = newValue.Scorer("n");
      var expected = 1;

      //Assert
      Assert.AreEqual(expected, result); 
    }
  }
}
