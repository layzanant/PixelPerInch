using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelApp;
using NUnit.Framework;

namespace PixelAppTest
{
    [TestFixture]
    public class PixelCalcTest
    {
        //Happy Path
        [Test]
        public void PixelCalcTestWidth1900height1000diag16()
        {
            // Arrange
            int width = 1900;
            int height = 1000;
            int diagonal = 16;
            double expectedPPI = 2147.091055358389;
            double expectedDotPitch = 3.4707158351409976E-06;


            double actualPPI = PixelCalc.CalculatePPI(width, height, diagonal);
            double actualDotPitch = PixelCalc.CalculateDotPitch(width, height, diagonal);

            Assert.AreEqual(expectedPPI, actualPPI);
            Assert.AreEqual(expectedDotPitch, actualDotPitch);

        }

        // Happy path

        [Test]
        public void PixelCalcTestWidth1999height1999diag20()
        {
            // Arrange


            int width = 1999;
            int height = 1999;
            int diagonal = 20;
            double expectedPPI = 2827.0129111838169;
            double expectedDotPitch = 2.5025018762507821E-06;

            double actualPPI = PixelCalc.CalculatePPI(width, height, diagonal);
            double actualDotPitch = PixelCalc.CalculateDotPitch(width, height, diagonal);

            Assert.AreEqual(expectedPPI, actualPPI);
            Assert.AreEqual(expectedDotPitch, actualDotPitch);

        }
    }
}
