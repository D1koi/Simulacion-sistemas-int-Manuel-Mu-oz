using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{

    /*public Vector2 vectorC;
    public Vector2 vectorD;
    public Vector2 vectorE;
    public Vector2 vectorF;*/

    float escalar = 5;
    vector first = new vector(-3, 2);
    vector second = new vector(1, 0);

    vector v1;
    vector v2 ;
    vector v3;
    vector resutado;
    public Vector2 vector1;
    public Vector2 vector2;
    public Vector2 vector3;


    [SerializeField] [Range(0, 1)] float t;
    



    // Start is called before the first frame update
    void Start()
    {
        /*
        var resutado = vector.Suma(first, second);
        vectorC = new Vector2(resutado.x, resutado.y);
        var resutado2 = vector.Resta(first, second);
        vectorD = new Vector2(resutado2.x, resutado2.y);
        var resutado3 = vector.multi(first,escalar);
        vectorE = new Vector2(resutado3.x, resutado3.y);
        var resutado4 = vector.magnitud(first);
        var resutado5 = vector.normalizar(first, resutado4);
        vectorF = new Vector2(resutado5.x, resutado5.y);

        print(resutado.ToString());
        print(resutado2.ToString());
        print(resutado3.ToString());
        print(resutado4.ToString());
        print(resutado5.ToString());*/




        /*var resutado = vector.Resta(v3, v1);
        v2 = new vector(resutado.x, resutado.y);
        var resutado2 = vector.Suma(v1, v2);
        vector2 = new Vector2(resutado2.x, resutado2.y);*/



        /* vector1 = new Vector2(v1.x, v1.y);

         vector3 = new Vector2(v3.x, v3.y);*/
        vector1 = new Vector2(2, 2);
        vector3 = new Vector2(-1, 3);



    }

    // Update is called once per frame


   void FixedUpdate()
    {

        v1 = new vector(vector1.x, vector1.y);
        v3 = new vector(vector3.x, vector3.y);

        resutado = vector.leep(v1, v3, t);

        vector2= new Vector2(resutado.x, resutado.y);


       

        /* vector.draw(vectorC, Color.green);
         vector.draw(vectorD, Color.red);
         vector.draw(vectorE, Color.blue);
         vector.draw(vectorF, Color.black);*/

        vector.draw(vector1, Color.red);
        vector.draw(vector2, Color.yellow);
        vector.draw(vector3, Color.green);



    }

}
