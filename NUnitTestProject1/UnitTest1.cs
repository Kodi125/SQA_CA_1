/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 9-3-2019
 * Description : CA1 C# Code for Software Quality and Testing
 *
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SQA_CA_1;

namespace NUnitTestProject1
{
    [TestFixture]

    public class Tests
    {

        [Test]
        public void Test1()
        {
            //18 AND URBAN
            //arrange
            InsuranceService p1 = new InsuranceService();
            //act
            double actualResult = p1.CalcPremium(18, "urban");
            //assert
            Assert.That(actualResult, Is.EqualTo(50));
        }
        [Test]
        public void Test2()
        {
            //31 AND URBAN
            //arrange
            InsuranceService p1 = new InsuranceService();
            //act
            double actualResult = p1.CalcPremium(31, "urban");
            //assert
            Assert.That(actualResult, Is.EqualTo(35));
        }
        [Test]
        public void Test3()
        {
            //51 AND URBAN
            //arrange
            InsuranceService p1 = new InsuranceService();
            //act
            double actualResult = p1.CalcPremium(51, "urban");
            //assert
            Assert.That(actualResult, Is.EqualTo(30));
        }
        [Test]
        public void Test4()
        {
            //18 AND RURAL
            //arrange
            InsuranceService p1 = new InsuranceService();
            //act
            double actualResult = p1.CalcPremium(18, "rural");
            //assert
            Assert.That(actualResult, Is.EqualTo(60));
        }
        [Test]
        public void Test5()
        {
            //36 AND RURAL
            //arrange
            InsuranceService p1 = new InsuranceService();
            //act
            double actualResult = p1.CalcPremium(36, "rural");
            //assert
            Assert.That(actualResult, Is.EqualTo(50));
        }
        [Test]
        public void Test6()
        {
            //51 AND RURAL
            //arrange
            InsuranceService p1 = new InsuranceService();
            //act
            double actualResult = p1.CalcPremium(51, "rural");
            //assert
            Assert.That(actualResult, Is.EqualTo(25));
        }
        [Test]
        public void Test7()
        {
            //17 (UNDERAGE) AND RURAL
            //arrange
            InsuranceService p1 = new InsuranceService();
            //act
            double actualResult = p1.CalcPremium(17, "urban");
            //assert
            Assert.That(actualResult, Is.EqualTo(0));
        }
        [Test]
        public void Test8()
        {
            //18 AND FDEGHWJHEEDHJEGR (INVALID LOCATION)
            //arrange
            InsuranceService p1 = new InsuranceService();
            //act
            double actualResult = p1.CalcPremium(18, "FDEGHWJHEEDHJEGR");
            //assert
            Assert.That(actualResult, Is.EqualTo(0));
        }
    }
}