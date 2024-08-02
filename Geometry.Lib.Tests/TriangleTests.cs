using Geometry.Lib.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Lib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Constructor_ShouldSetSides_WhenSidesAreValid()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;

            // Act
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
        }

        [Fact]
        public void Constructor_ShouldThrowArgumentException_WhenAnySideIsNonPositive()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-3.0, 4.0, 5.0));
            Assert.Throws<ArgumentException>(() => new Triangle(3.0, -4.0, 5.0));
            Assert.Throws<ArgumentException>(() => new Triangle(3.0, 4.0, -5.0));
        }

        [Fact]
        public void Constructor_ShouldThrowArgumentException_WhenSidesDoNotFormTriangle()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1.0, 1.0, 3.0));
        }

        [Fact]
        public void CalculateArea_ShouldReturnCorrectArea_WhenSidesAreValid()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6.0;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void IsRight_ShouldReturnTrue_WhenTriangleIsRight()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRight = triangle.IsRight();

            // Assert
            Assert.True(isRight);
        }

        [Fact]
        public void IsRight_ShouldReturnFalse_WhenTriangleIsNotRight()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 6.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRight = triangle.IsRight();

            // Assert
            Assert.False(isRight);
        }
    }
}
