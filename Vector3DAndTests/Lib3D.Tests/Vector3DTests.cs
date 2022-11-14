namespace Lib3D.Tests
{
    using Lib3D;
    using NUnit.Framework;
    
    [TestFixture]
    public class Vector3DTests
    {
        private Vector3D _sut = new();

        [SetUp]
        public void Init()
        {
            _sut = new Vector3D(0.0f, 0.0f, 0.0f);
        }

        [Test]
        public void Vector3D_Scale_ReturnsCorrectResult()
        {
            _sut = new Vector3D(10.0f, 20.0f, 30.0f);

            var result = _sut.Scale(0.5f);
            
            Assert.IsTrue(result.Equals(new Vector3D(5.0f, 10.0f, 15.0f)));
        }

        [Test]
        public void Vector3D_Translate_ReturnsCorrectResult()
        {
            var unitVector = new Vector3D(1.0f, 1.0f, 1.0f);
            
            var result = _sut.Translate(unitVector);
            
            Assert.IsTrue(result.Equals(unitVector));
        }

        [Test]
        public void Vector3D_RotateXAxis_ReturnsCorrectResult()
        {
            _sut = new Vector3D(1.0f, 0.5f, 0.0f);
            var result = _sut.RotateX(90.0f);
            Assert.AreEqual(new Vector3D(1.0f, 0.0f, -0.5f), result);
        }

        [TestCaseSource(typeof(Vector3DTestData), nameof(Vector3DTestData.RotationYData))]
        public Vector3D Vector3D_RotateYAxis_ReturnsCorrectResult(Vector3D sut, float angle)
        {
            var result = sut.RotateY(angle);
            return result;
        }
        
        [TestCaseSource(typeof(Vector3DTestData), nameof(Vector3DTestData.RotationZData))]
        public Vector3D Vector3D_RotateZAxis_ReturnsCorrectResult(Vector3D sut, float angle)
        {
            var result = sut.RotateZ(angle);
            return result;
        }
    }
}