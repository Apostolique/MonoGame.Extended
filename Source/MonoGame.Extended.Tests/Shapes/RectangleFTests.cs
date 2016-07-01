using Microsoft.Xna.Framework;
using MonoGame.Extended.Shapes;
using NUnit.Framework;

namespace MonoGame.Extended.Tests.Shapes
{
    [TestFixture]
    public class RectangleFTests
    {
        [Test]
        public void RectangleF_Intersects_Test()
        {
            var rect1 = new RectangleF(0, 0, 32, 32);
            var rect2 = new RectangleF(32, 32, 32, 32);

            Assert.IsFalse(rect1.Intersects(rect2));
        }

        [Test]
        public void Rectangle_Intersects_Test()
        {
            var rect1 = new Rectangle(0, 0, 32, 32);
            var rect2 = new Rectangle(32, 32, 32, 32);

            Assert.IsFalse(rect1.Intersects(rect2));
        }
    }
}