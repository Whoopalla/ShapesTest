using Shapes.Common;
using Shapes.Shapes;
using Xunit;

namespace UnitTests.Shapes {
    public class CircleTests {
        [Fact]
        public void AreaWithCorrectRadius() {
            var radius = 11.7;
            Circle circle = new Circle(radius);

            var actualArea = circle.Area();
            var expectedArea = Math.PI * Math.Pow(radius, 2);

            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void AreaWithRadiusZero() {
            var radius = 0;

            static Circle CreateCircleWithWrongRadius(double radius) {
                return new Circle(radius);
            }

            Assert.Throws<ArgumentOutOfRangeException>(() => CreateCircleWithWrongRadius(radius));
        }

        [Fact]
        public void AreaWithNegativeRadius() {
            var radius = -14;

            static Circle CreateCircleWithWrongRadius(double radius) {
                return new Circle(radius);
            }

            Assert.Throws<ArgumentOutOfRangeException>(() => CreateCircleWithWrongRadius(radius));
        }

        [Fact]
        public void WrongRadiusWithCenter() {
            var radius = -14;
            var center = new Point(4, 14);

            static Circle CreateCircleWithWrongRadius(double radius, Point center) {
                return new Circle(radius, center);
            }

            Assert.Throws<ArgumentOutOfRangeException>(() => CreateCircleWithWrongRadius(radius, center));
        }

        [Fact]
        public void CorrectRadiusWithCenter() {
            var radius = 15;
            var center = new Point(4, 14);
            Circle circle = new Circle(radius, center);

            var actualArea = circle.Area();
            var expectedArea = Math.PI * Math.Pow(radius, 2);

            Assert.Equal(expectedArea, actualArea);
        }
    }
}
