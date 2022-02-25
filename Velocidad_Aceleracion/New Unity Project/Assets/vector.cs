using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector
{
    public float x;
    public float y;

   

    public vector(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return ("(" + x + "," + y + ")");
    }
    public static vector Suma(vector a, vector b)
    {
        vector resutado= new vector(a.x + b.x, a.y+b.y);

        return resutado;

    }

    public static vector Resta(vector a, vector b)
    {
        vector resutado2 = new vector(a.x - b.x, a.y - b.y);

        return resutado2;

    }
    public static vector multi(vector a,  float escalar)
    {
        vector resutado3 = new vector(a.x * escalar, a.y *escalar);

        return resutado3;

    }

    public static vector leep(vector a, vector b, float t)
    {
        vector resutado6 = new vector(a.x * (1 - t) + b.x * t, a.y * (1 - t) + b.y * t);

        return resutado6;
    }
    public static float magnitud(vector a)
    {
        float resutado4 = Mathf.Sqrt( a.x * a.x + a.y * a.y);

        return resutado4;

    }


    public static vector normalizar(vector a, float resultado4)
    {
        vector resutado5 = new vector(a.x / resultado4, a.y / resultado4);
        return resutado5;


   }

    public static Vector2 draw(Vector2 resutado,Color color)
    {
        Debug.DrawLine(Vector3.zero, resutado, color, 0);
        return resutado;
    }
}
