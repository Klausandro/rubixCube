using NUnit.Framework;

namespace Lib3D.Tests;

[TestFixture]
public class CuboidTests
{
    private Cuboid _sut;

    [SetUp]
    public void Init()
    {
        _sut = new Cuboid();
    }

    [Test]
    public void Cuboid_GetCorner_ReturnsCorrectCorners()
    {
        var corners = _sut.GetCorners();
        
        Assert.That(corners, Contains.Item(new Vector3D(-0.5f, -0.5f, 0.5f)));
        Assert.That(corners, Contains.Item(new Vector3D(0.5f, -0.5f, 0.5f)));
        Assert.That(corners, Contains.Item(new Vector3D(0.5f, -0.5f, -0.5f)));
        Assert.That(corners, Contains.Item(new Vector3D(-0.5f, -0.5f, -0.5f)));
        Assert.That(corners, Contains.Item(new Vector3D(-0.5f, 0.5f, 0.5f)));
        Assert.That(corners, Contains.Item(new Vector3D(0.5f, 0.5f, 0.5f)));
        Assert.That(corners, Contains.Item(new Vector3D(0.5f, 0.5f, -0.5f)));
        Assert.That(corners, Contains.Item(new Vector3D(-0.5f, 0.5f, -0.5f)));
    }
    
    [Test]
    public void CuboidRotated_GetCorner_ReturnsCorrectCorners()
    {
        _sut = new Cuboid(new Vector3D(), 2.0f, 2.0f, 4.0f, new Vector3D(0.0f, 1.0f, 0.0f));
        var corners = _sut.GetCorners();
        
        Assert.That(corners, Contains.Item(new Vector3D(-1.0f, -2.0f, 1.0f)));
        Assert.That(corners, Contains.Item(new Vector3D(1.0f, -2.0f, 1.0f)));
        Assert.That(corners, Contains.Item(new Vector3D(1.0f, -2.0f, -1.0f)));
        Assert.That(corners, Contains.Item(new Vector3D(-1.0f, -2.0f, -1.0f)));
        Assert.That(corners, Contains.Item(new Vector3D(-1.0f, 2.0f, 1.0f)));
        Assert.That(corners, Contains.Item(new Vector3D(1.0f, 2.0f, 1.0f)));
        Assert.That(corners, Contains.Item(new Vector3D(1.0f, 2.0f, -1.0f)));
        Assert.That(corners, Contains.Item(new Vector3D(-1.0f, 2.0f, -1.0f)));
    }
}