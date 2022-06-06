using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotMove : MonoBehaviour
{
    //floats
    public float speed;
    public float time;


    //Bools

    //Ints

    //Strings

    //Components
    private Rigidbody2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.deltaTime;

        Vector2 thrust = new Vector2(this.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude, this.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude);
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * time, speed * time);
    }

    // Update is called once per frame
    void Update()
    {

        

        


    }
}
