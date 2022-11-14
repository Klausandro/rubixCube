
namespace Lib3D;

public class Vector2D
{
    public float X { get; set; }

    public float Y { get; set; }

    public Vector2D()
    {
    }

    public Vector2D(float x, float y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Vector2D other)
            return MathF.Abs(MathF.Abs(X - other.X)) < 0.1f && MathF.Abs(MathF.Abs(Y - other.Y)) < 0.1f;

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public Vector2D Scale(float factor)
    {
        // TODO: Implement Method
        return new Vector2D
        {
            X = 2*X,
            Y = 2*Y
        };
        
        throw new NotImplementedException();
    }
    
    public Vector2D Translate(Vector2D vector)
    {
        return new Vector2D
        {
            X = X + vector.X,
            Y = Y + vector.Y
        }; 
        throw new NotImplementedException();
    }

    public Vector2D Rotate(float angle)
    {
        angle = Utils.GetDegree(angle);
        return new Vector2D
        { 
            X = X * MathF.Cos(angle) - Y * MathF.Sin(angle),
            Y = X * MathF.Sin(angle) + Y * MathF.Cos(angle)
        }; 
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{X} / {Y}";
    }
}