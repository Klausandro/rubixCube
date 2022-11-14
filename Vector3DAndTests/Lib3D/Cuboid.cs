namespace Lib3D;

public class Cuboid
{
    private Vector3D _up;
    
    public Vector3D Center { get; private set; }
    
    public float Length { get; private set; }
    
    public float Width { get; private set; }
    
    public float Height { get; private set; }

    public Cuboid()
    {
        Center = new Vector3D(0.0f, 0.0f, 0.0f);
        Length = 1.0f;
        Width = 1.0f;
        Height = 1.0f;
        _up = new Vector3D(0.0f, 1.0f, 0.0f);
    }

    public Cuboid(Vector3D center, float length, float width, float height, Vector3D up)
    {
        Center = center;
        Length = length;
        Width = width;
        Height = height;
        _up = up;
    }

    public List<Vector3D> GetCorners()
    {
        List<Vector3D> kek = new List<Vector3D>();
        kek.Add(Center.Translate(new Vector3D(Length/2,Height/2,Width/2)));
        kek.Add(Center.Translate(new Vector3D(Length/2,Height/2,-Width/2)));
        kek.Add(Center.Translate(new Vector3D(Length/2,-Height/2,Width/2)));
        kek.Add(Center.Translate(new Vector3D(Length/2,-Height/2,-Width/2)));
        kek.Add(Center.Translate(new Vector3D(-Length/2,Height/2,Width/2)));
        kek.Add(Center.Translate(new Vector3D(-Length/2,Height/2,-Width/2)));
        kek.Add(Center.Translate(new Vector3D(-Length/2,-Height/2,Width/2)));
        kek.Add(Center.Translate(new Vector3D(-Length/2,-Height/2,-Width/2)));
        return kek;
    }
}