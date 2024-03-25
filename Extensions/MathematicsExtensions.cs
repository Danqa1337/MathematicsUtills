using System;

public class MathematicsExtensions
{
    public static float Magnitude(this float2 vector)
    {
        return math.sqrt(math.pow(vector.x, 2) + math.pow(vector.y, 2));
    }

    public static float SqrMagnitude(this float2 vector)
    {
        return math.pow(vector.x, 2) + math.pow(vector.y, 2);
    }

    public static float Magnitude(this int2 vector)
    {
        return math.sqrt(math.pow(vector.x, 2) + math.pow(vector.y, 2));
    }

    public static float SqrMagnitude(this int2 vector)
    {
        return math.pow(vector.x, 2) + math.pow(vector.y, 2);
    }

    public static Vector3 ToVector3(this Vector2 vector, float z)
    {
        return new Vector3(vector.x, vector.y, z);
    }

    public static float2 Normalize(this float2 vector)
    {
        return math.normalize(vector);
    }

    public static Vector3 ToVector3(this float2 vector)
    {
        return new Vector3(vector.x, vector.y, 0);
    }

    public static Vector2 ToVector2(this float2 vector)
    {
        return new Vector2(vector.x, vector.y);
    }

    public static float2 ToFloat2(this Vector3 vector)
    {
        return new float2(vector.x, vector.y);
    }

    public static float3 ToFloat3(this Vector3 vector)
    {
        return new float3(vector.x, vector.y, vector.z);
    }
    public static Vector2 ToVector2X(this float value)
    {
        return new Vector2(value, 0);
    }

    public static Vector2 ToVector2Y(this float value)
    {
        return new Vector2(0, value);
    }

    public static float2 ToFloat2(this float3 vector)
    {
        return new float2(vector.x, vector.y);
    }

    public static Vector3 ToVector3(this float3 vector)
    {
        return new Vector3(vector.x, vector.y, vector.z);
    }

    public static float2 ToFloat2(this Vector2 vector)
    {
        return new float2(vector.x, vector.y);
    }

    public static Vector3 ToRealPosition(this float2 vector)
    {
        return new Vector3(vector.x, vector.y, vector.y * 10);
    }

    public static int2 ToMapPosition(this int index, int mapSizeX = 64, int mapSizeY = 64, int shift = 0)
    {
        int x = Mathf.Max(index % mapSizeX, 0);
        int y = (index - x) / mapSizeY;
        return new int2(x + shift, y + shift);
    }

    public static int2 ToInt2(this Vector2 vector)
    {
        return new int2((int)vector.x, (int)vector.y);
    }

    public static int2 ToInt2(this Vector3 vector)
    {
        return new int2((int)vector.x, (int)vector.y);
    }

    public static Vector3 ToRealPosition(this int2 vector)
    {
        return new Vector3(vector.x, vector.y, vector.y * 10);
    }

    public static Vector2Int ToVector2(this int2 vector)
    {
        return new Vector2Int(vector.x, vector.y);
    }

    public static Vector2 ToVector3(this int2 vector)
    {
        return new Vector3(vector.x, vector.y, 0);
    }

    public static int ToMapIndex(this int2 position, int width, int height)
    {
        if (position.x >= 0 && position.x < width && position.y >= 0 && position.y < height)
        {
            return position.y * width + position.x;
        }
        else
        {
            return -1;
        }
    }

    public static int ToMapIndex(this float2 vector)
    {
        int2 v = (int2)vector;
        return ToMapIndex(v);
    }

    public static int ToMapIndex(this int2 v)
    {
        return ToMapIndex(v, 64, 64);
    }

    public static bool Contains(this Bounds bounds, float2 vector)
    {
        return bounds.Contains(vector.ToVector3());
    }

    public static void Randomize(this float2 center, float range)
    {
        center.x += UnityEngine.Random.Range(-range, range);
        center.y += UnityEngine.Random.Range(-range, range);
    }

    public static float GetDistance(this int2 start, int2 target)
    {
        return (target - start).Magnitude();
    }

    public static float GetSqrDistance(this int2 start, int2 target)
    {
        return (target - start).SqrMagnitude();
    }



}
