namespace Lib3D.Tests
{
    using Lib3D;
    using NUnit.Framework;
    
    [TestFixture]
    public class Vector2DTests
    {
        private Vector2D _sut = new();

        [SetUp]
        public void Init()
        {
            _sut = new Vector2D(0.0f, 0.0f);
        }

        [Test]
        public void Vector2D_Scale_ReturnsCorrectResult()
        {
            _sut = new Vector2D(10.0f, 20.0f);
            
            var result = _sut.Scale(2.0f);
            
            Assert.IsTrue(result.Equals(new Vector2D(20.0f, 40.0f)));
        }

        [Test]
        public void Vector2D_Translate_ReturnsCorrectResult()
        {
            var custom = new Vector2D(1.0f, 1.0f);
            
            var result = _sut.Translate(custom);
            
            Assert.IsTrue(result.Equals(custom));
        }
        
        [Test]
        public void Vector2D_TranslateNegativ_ReturnsCorrectResult()
        {
            var custom = new Vector2D(-1.0f, -1.0f);
            
            var result = _sut.Translate(custom);
            
            Assert.IsTrue(result.Equals(custom));
        }

        [Test]
        public void Vector2DSingleTest_Rotate_ReturnsCorrectResult()
        {
            _sut = new Vector2D(1.0f, 0.5f);
            var result = _sut.Rotate(90.0f);
            Assert.IsTrue(result.Equals(new Vector2D(-0.5f, 1.0f)));
        }

        [TestCaseSource(typeof(Vector2DTestData), nameof(Vector2DTestData.RotationData))]
        public Vector2D Vector2D_Rotate_ReturnsCorrectResult(Vector2D sut, float angle)
        {
            var result = sut.Rotate(angle);
            return result;
        }
    }
}