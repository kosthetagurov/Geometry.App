using Geometry.Lib.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Lib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Constructor_ShouldSetRadius_WhenRadiusIsValid()
        {
            // Arrange
            double radius = 5.0;

            // Act
            Circle circle = new Circle(radius);

            // Assert
            Assert.Equal(radius, circle.Radius);
        }

        [Fact]
        public void Constructor_ShouldThrowArgumentException_WhenRadiusIsNegative()
        {
            // Arrange
            double negativeRadius = -5.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(negativeRadius));
        }

        [Fact]
        public void CalculateArea_ShouldReturnCorrectArea_WhenRadiusIsValid()
        {
            // Arrange
            double radius = 5.0;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 5); 
        }

        [Fact]
        public void CalculateArea_ShouldReturnZero_WhenRadiusIsZero()
        {
            // Arrange
            double radius = 0.0;
            Circle circle = new Circle(radius);
            double expectedArea = 0.0;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }
    }
}
