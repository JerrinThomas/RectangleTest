using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment02;

/**
 * Assignment 2 Test Class
 * 
 * Jerrin Thomas
 * 8770668
 * 
 */
namespace Assignment02Tests
{
    public class RectangleTests
    {
        [TestFixture]
        public class RectangleTest
        {
            [Test]
            public void GetLength_InputDefault_Expected1()
            {
                // Arrange
                Rectangle rect = new Rectangle();
                int expected = 1;

                // Act
                int actual = rect.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetLength_Input0and0_ExpectedException()
            {
                // Arrange
                int length = 0;
                int width = 0;

                // Act
                Rectangle rect = new Rectangle(length, width);

                // Assert
                Assert.Throws<Exception>(() => rect.GetLength());
            }

            [Test]
            public void GetLength_InputNegative1andNegative5_ExpectedException()
            {
                // Arrange
                int length = -1;
                int width = -5;

                // Act
                Rectangle rect = new Rectangle(length, width);

                // Assert
                Assert.Throws<Exception>(() => rect.GetLength());
            }


            [Test]
            public void SetLength_Input10_Expected10()
            {
                // Arrange
                int length = 10;
                int expected = 10;
                Rectangle rect = new Rectangle();

                // Act
                int actual = rect.SetLength(length);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void SetLength_Input0_ExpectedException()
            {
                // Arrange
                int length = 0;
                Rectangle rect = new Rectangle();

                // Assert
                Assert.Throws<Exception>(() => rect.SetLength(length));
            }

            [Test]
            public void SetLength_InputNegative1_ExpectedException()
            {
                // Arrange
                int length = -1;
                Rectangle rect = new Rectangle();

                // Assert
                Assert.Throws<Exception>(() => rect.SetLength(length));
            }


            [Test]
            public void GetWidth_InputDefault_Expected1()
            {
                // Arrange
                Rectangle rect = new Rectangle();
                int expected = 1;

                // Act
                int actual = rect.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetWidth_Input0and0_ExpectedException()
            {
                // Arrange
                int length = 0;
                int width = 0;

                // Act
                Rectangle rect = new Rectangle(length, width);

                // Assert
                Assert.Throws<Exception>(() => rect.GetWidth());
            }

            [Test]
            public void GetWidth_InputNegative10andNegative50_ExpectedException()
            {
                // Arrange
                int length = -10;
                int width = -50;

                // Act
                Rectangle rect = new Rectangle(length, width);

                // Assert
                Assert.Throws<Exception>(() => rect.GetWidth());
            }

            [Test]
            public void SetWidth_Input10_Expected10()
            {
                // Arrange
                int width = 10;
                int expected = 10;
                Rectangle rect = new Rectangle();

                // Act
                int actual = rect.SetWidth(width);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void SetWidth_Input0_ExpectedException()
            {
                // Arrange
                int width = 0;

                // Act
                Rectangle rect = new Rectangle();

                // Assert
                Assert.Throws<Exception>(() => rect.SetWidth(width));
            }

            [Test]
            public void SetWidth_InputNegative10_ExpectedException()
            {
                // Arrange
                int width = -10;

                // Act
                Rectangle rect = new Rectangle();

                // Assert
                Assert.Throws<Exception>(() => rect.SetLength(width));
            }

            [Test]
            public void GetPerimeter_Input10and20_Expected60()
            {
                // Arrange
                int length = 10;
                int width = 20;
                Rectangle rect = new Rectangle(length, width);
                int expected = 60;

                // Act
                int actual = rect.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetPerimeter_Input0and0_ExpectedException()
            {
                // Arrange
                int length = 0;
                int width = 0;
                Rectangle rect = new Rectangle(length, width);

                // Assert
                Assert.Throws<Exception>(() => rect.GetPerimeter());
            }

            [Test]
            public void GetPerimeter_InputNegative5andNegative10_ExpectedException()
            {
                // Arrange
                int length = -5;
                int width = -10;
                Rectangle rect = new Rectangle(length, width);

                // Assert
                Assert.Throws<Exception>(() => rect.GetPerimeter());
            }


            [Test]
            public void GetArea_Input10and10_Expected100()
            {
                // Arrange
                int length = 10;
                int width = 10;
                Rectangle rect = new Rectangle(length, width);
                int expected = 100;

                // Act
                int actual = rect.GetArea();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetArea_Input0and0_ExpectedException()
            {
                // Arrange
                int length = 0;
                int width = 0;
                Rectangle rect = new Rectangle(length, width);

                // Assert
                Assert.Throws<Exception>(() => rect.GetArea());
            }

            [Test]
            public void GetArea_InputNegative5andNegative10_ExpectedException()
            {
                // Arrange
                int length = -5;
                int width = -10;
                Rectangle rect = new Rectangle(length, width);

                // Assert
                Assert.Throws<Exception>(() => rect.GetArea());
            }

        }
    }
}
