using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    Vector3 desplazamineto;
    [SerializeField] Vector3 velocity;
    [SerializeField] float xBordex, yBordex;
    [SerializeField] Vector3 aceleracion;
    Vector3 dibujado;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moving();
        checkCollision();
	}

    public void moving()
    {
        desplazamineto = velocity * Time.deltaTime + (aceleracion * Mathf.Pow(Time.deltaTime, 2) / 2);
        velocity = velocity + aceleracion* Time.deltaTime;
        
        
        transform.position = transform.position  +desplazamineto;
           

        dibujado = transform.position + velocity;

        Debug.DrawLine(transform.position, dibujado, Color.red  , 0);
        Debug.DrawLine(transform.position, desplazamineto, Color.yellow, 0);
        Debug.DrawLine(transform.position, velocity, Color.black, 0);
        Debug.DrawLine(transform.position, aceleracion, Color.blue, 0);




    }

    private void checkCollision()
    {
        if(transform.position.x>= xBordex|| transform.position.x<= -xBordex)
        {
            velocity.x = velocity.x * -1;
            aceleracion.x = aceleracion.x - 0.5f;

        }
        else if(transform.position.y >= yBordex|| transform.position.y<= -yBordex)
        {
            velocity.y = velocity.y * -1;

            aceleracion.y = aceleracion.y - 0.5f;
        }
    }
}
