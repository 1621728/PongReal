using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotMove : MonoBehaviour
{
    //floats
    public float speed;
    public float time;
    public float maxSpeed;

    //Bools

    //Ints

    //Strings

    //Components
    private Rigidbody2D rb2;

    //Prefabs
    public GameObject dust;

    // Start is called before the first frame update
    void Start()
    {
        time = Time.deltaTime;

        rb2 = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 thrust = new Vector2(this.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude, this.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude);
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * time, speed * time);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (ContactPoint2D contact in collision.contacts)
        {
            
            if (collision.gameObject)
            {
                Instantiate(dust, contact.point, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {


        if(rb2.velocity.magnitude > maxSpeed)
        {
            rb2.velocity = Vector2.ClampMagnitude(rb2.velocity, maxSpeed);
        }


    }
}
