using UnityEngine;

public static class BezierCurve
{
    public static Vector3 EvaluateCubic(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        float u = 1f - t;
        float tt = t * t;
        float uu = u * u;
        float uuu = uu * u;
        float ttt = tt * t;

        Vector3 p = uuu * p0;
        p += 3f * uu * t * p1;
        p += 3f * u * tt * p2;
        p += ttt * p3;

        return p;
    }

    public static Vector3 EvaluateCubicDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        float u = 1f - t;
        float tt = t * t;
        float uu = u * u;

        Vector3 p = -3f * uu * p0;
        p += (3f * uu - 6f * u) * p1;
        p += (6f * u - 3f * tt) * p2;
        p += 3f * tt * p3;

        return p;
    }
}
