namespace Lib3D;

public class Sphere
{
    public Vector3D Center { get; set; }
    
    public float Radius { get; set; }

    public Sphere()
    {
        Center = new Vector3D();
        Radius = 1.0f;
    }
    
    public override bool Equals(object? obj)
    {
        // TODO: is that smart?
        if (obj is Sphere other)
            return Center == other.Center && Math.Abs(Radius - other.Radius) < 0.1f;

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Center.GetHashCode(), Radius);
    }

    public bool Intersects(Sphere other)
    {
        Vector3D v = Center.Translate(other.Center.Scale(-1));
        if(v.X*v.X + v.Y*v.Y + v.Z*v.Z <= (Radius+other.Radius)*(Radius+other.Radius))
        {
            return true;
        }
        return false;
    }

    public bool Contains(Sphere other)
    {
        if (Radius > other.Radius) {
            return true;
        }
        return false;
    }
}