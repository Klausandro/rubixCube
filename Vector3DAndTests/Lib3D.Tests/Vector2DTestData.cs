using NUnit.Framework;

namespace Lib3D.Tests;

public class Vector2DTestData
{
    public static IEnumerable<TestCaseData> RotationData
    {
        get
        {
            yield return new TestCaseData(new Vector2D(1.0f, 1.0f), -90.0f)
                .Returns(new Vector2D(1.0f, -1.0f));
            yield return new TestCaseData(new Vector2D(0.5f, 0.5f), -90.0f)
                .Returns(new Vector2D(0.5f, -0.5f));
            yield return new TestCaseData(new Vector2D(0.0f, 0.0f), -90.0f)
                .Returns(new Vector2D(0.0f, 0.0f));
            yield return new TestCaseData(new Vector2D(1.0f, 1.0f), 360.0f)
                .Returns(new Vector2D(1.0f, 1.0f));
            yield return new TestCaseData(new Vector2D(1.0f, 1.0f), 540.0f)
                .Returns(new Vector2D(-1.0f, -1.0f));
            yield return new TestCaseData(new Vector2D(0.12345f, 2.778f), 90.0f)
                .Returns(new Vector2D(-2.778f, 0.12345f));
            yield return new TestCaseData(new Vector2D(0.12345f, 2.778f), 22.1f)
                .Returns(new Vector2D(-0.9307710435f, 2.620341422f));
        }
    }
}