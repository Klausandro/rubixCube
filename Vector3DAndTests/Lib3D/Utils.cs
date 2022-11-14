namespace Lib3D;

public class Utils
{
    public float X;
    public float Y;

    public Utils()
    {
        
    }

    public static float GetDegree(float angle_r)
    {
        var angle_d = ( MathF.PI / 180 ) * angle_r;

        return angle_d;
    }
    
}