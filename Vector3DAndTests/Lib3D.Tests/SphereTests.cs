using NUnit.Framework;

namespace Lib3D.Tests;

[TestFixture]
public class SphereTests
{
    private Sphere _sut;

    [SetUp]
    public void Init()
    {
        _sut = new Sphere();
    }

    [Test]
    public void Sphere_IntersectsOtherSphereHalfIntersected_ReturnsTrue()
    {
        var otherSphere = new Sphere
        {
            Center = new Vector3D(1.0f, 0.0f, 0.0f),
            Radius = 1.0f
        };

        Assert.IsTrue(_sut.Intersects(otherSphere));
    }
    
    [Test]
    public void Sphere_IntersectsOtherSphereHalfIntersectedNegativ_ReturnsTrue()
    {
        var otherSphere = new Sphere
        {
            Center = new Vector3D(-1.0f, 0.0f, 0.0f),
            Radius = 1.0f
        };

        Assert.IsTrue(_sut.Intersects(otherSphere));
    }
    
    [Test]
    public void Sphere_IntersectsOtherSphereBarelyTouching_ReturnsTrue()
    {
        var otherSphere = new Sphere
        {
            Center = new Vector3D(2.0f, 0.0f, 0.0f),
            Radius = 1.0f
        };

        Assert.IsTrue(_sut.Intersects(otherSphere));
    }
    
    [Test]
    public void Sphere_DoesNotIntersectOtherSphere_ReturnsFalse()
    {
        var otherSphere = new Sphere
        {
            Center = new Vector3D(2.0f, 2.0f, 0.0f),
            Radius = 1.828f
        };

        Assert.IsFalse(_sut.Intersects(otherSphere));
    }

    [Test]
    public void Sphere_ContainsSmallerSphereWithSameCenter_ReturnsTrue()
    {
        var otherSpere = new Sphere
        {
            Center = _sut.Center,
            Radius = _sut.Radius * 0.9f
        };
        
        Assert.IsTrue(_sut.Contains(otherSpere));
    }
    
    [Test]
    public void Sphere_ContainsBiggerSphereWithSameCenter_ReturnsFalse()
    {
        var otherSpere = new Sphere
        {
            Center = _sut.Center,
            Radius = _sut.Radius * 1.1f
        };
        
        Assert.IsFalse(_sut.Contains(otherSpere));
    }
    
    [Test]
    public void Sphere_ContainsOtherSphereWithSurfacesTouching_ReturnsTrue()
    {
        var otherSpere = new Sphere
        {
            Center = new Vector3D(0.5f, 0.0f, 0.0f),
            Radius = 0.5f
        };
        
        Assert.IsTrue(_sut.Contains(otherSpere));
    }
}