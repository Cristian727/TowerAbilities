using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    public float speed = 20f;
    Rigidbody2D rb;
    Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ShotDirection(Vector3 directionToCursor)
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = directionToCursor * speed;
        print(directionToCursor.magnitude + " --- " + rb.velocity.magnitude);
    }

    // el script del proyectil tiene que poder recibir una direccion
    // al instanciar el proyectil, hay que pillarle el componente de movimiento y pasarle la direccion a la que quiero que mire.

}
