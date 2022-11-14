using NUnit.Framework;

namespace Lib3D.Tests;

public class Vector3DTestData
{
    public static IEnumerable<TestCaseData> RotationYData
    {
        get
        {
            yield return new TestCaseData(new Vector3D(1.0f, 1.0f, 1.0f), -90.0f)
                .Returns(new Vector3D(-1.0f, 1.0f, 1.0f));
        }
    }
    
    public static IEnumerable<TestCaseData> RotationZData
    {
        get
        {
            yield return new TestCaseData(new Vector3D(0.0f, 1.0f, 0.0f), 180.0f)
                .Returns(new Vector3D(0.0f, -1.0f, 0.0f));
        }
    }
}