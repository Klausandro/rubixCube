using System.Numerics;

namespace Lib3D;

public class Vector3D
{
    public float X { get; set; }

    public float Y { get; set; }
    
    public float Z { get; set; }

    public Vector3D()
    {
    }

    public Vector3D(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Vector3D other)
            return Math.Abs(Math.Abs(X - other.X)) < 0.1f && Math.Abs(Math.Abs(Y - other.Y)) < 0.1f && Math.Abs(Math.Abs(Z - other.Z)) < 0.1f;

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    public Vector3D Scale(float factor)
    {
        Vector3D newVector3D = new Vector3D
        {
            X = factor * X,
            Y = factor * Y,
            Z = factor * Z
        };

        return newVector3D;
    }

    public Vector3D Translate(Vector3D vector)
    {
        Vector3D v = new Vector3D();
        v.X = X + vector.X;
        v.Y = Y + vector.Y;
        v.Z = Z + vector.Z;

        return v;
    }
    
    public Vector3D RotateX(float angle)
    {
        float angleToDegree = Utils.GetDegree(angle);
        Vector3D newVector3D = new Vector3D();
        
        newVector3D.X = X;
        newVector3D.Y = Y * MathF.Cos(angleToDegree) - Z * MathF.Sin(angleToDegree);
        newVector3D.Z = - Y * MathF.Sin(angleToDegree) + Z * MathF.Cos(angleToDegree);
        return newVector3D;
    }

    public Vector3D RotateY(float angle)
    {
        float t = Utils.GetDegree(angle);
        Vector3D v = new Vector3D();
        v.X = X * MathF.Cos(t) - Z*MathF.Sin(t);
        v.Y = Y;
        v.Z = X*MathF.Sin(t) + Z*MathF.Cos(t);

        return v; 
    }

    public Vector3D RotateZ(float angle)
    {

        float t = Utils.GetDegree(angle);
        Vector3D v = new Vector3D();
        v.X = X * MathF.Cos(t)-Y*MathF.Sin(t);
        v.Y = X*MathF.Sin(t)+Y*MathF.Cos(t);
        v.Z = Z;

        return v; 
        
    }

    public override string ToString()
    {
        return $"{X} /{Y} /{Z}";
    }
}
