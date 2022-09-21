using Shapes.Common;
using Shapes.Common.Exceptions;
using Shapes.Shapes;
using Xunit;

namespace UnitTests.Shapes {
    public class TriangleTests {
        [Fact]
        public void CorrectPointsArea() {
            Triangle triangle = new Triangle(new Point(0, 0), new Point(0, 1), new Point(1, 0));

            var actualArea = triangle.Area();
            var expectedArea = 0.5;

            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CorrectPointsOtherArea() {
            Triangle triangle = new Triangle(new Point(0, 0), new Point(0, -2), new Point(-2, 0));

            var actualArea = triangle.Area();
            var expectedArea = 2;

            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void IsRigthCorrectInput() {
            Triangle triangle = new Triangle(new Point(0, 0), new Point(0, 1), new Point(1, 0));

            var actualIsRight = triangle.IsRight;
            var expectedArea = true;

            Assert.Equal(expectedArea, actualIsRight);
        }

        [Fact]
        public void IsRigthSecondCorrectInput() {
            Triangle triangle = new Triangle(new Point(0, 0), new Point(0, 19999.93), new Point(1, 0));

            var actualIsRight = triangle.IsRight;
            var expectedArea = true;

            Assert.Equal(expectedArea, actualIsRight);
        }

        [Fact]
        public void IsRigthWrongInput() {
            Triangle triangle = new Triangle(new Point(0, 0), new Point(0, 1), new Point(1, 0.5));

            var actualIsRight = triangle.IsRight;
            var expectedArea = false;

            Assert.Equal(expectedArea, actualIsRight);
        }

        [Fact]
        public void IsRigthWrongInputSecondInput() {
            // equilateral triangle
            Triangle triangle = new Triangle(new Point(0, 0), new Point(5, 5 * Math.Sqrt(3)), new Point(10, 0));

            var actualIsRight = triangle.IsRight;
            var expectedArea = false;

            Assert.Equal(expectedArea, actualIsRight);
        }

        [Fact]
        public void SamePointExceptionOneSamePoint() {

            static Triangle CreateCircleWithWrongRadius() {
                return new Triangle(new Point(0, 0), new Point(0, 0), new Point(10, 0));
            }

            Assert.Throws<SamePointUsedByOneShapeException>(() => CreateCircleWithWrongRadius());
        }

        [Fact]
        public void SamePointExceptionAllSamePoints() {

            static Triangle CreateCircleWithWrongRadius() {
                return new Triangle(new Point(0, 0), new Point(0, 0), new Point(0, 0));
            }

            Assert.Throws<SamePointUsedByOneShapeException>(() => CreateCircleWithWrongRadius());
        }
    }
}
