using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //floats
    public float speed;
    public float time;
    public float bounds;


    //Bools

    //Ints

    //Strings

    //Components
    private Rigidbody2D rb2;
    private Transform xt;

    // Start is called before the first frame update
    void Start()
    {
        time = Time.deltaTime;

        rb2 = GetComponent<Rigidbody2D>();

        xt = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {

        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector2(0, v);
        tempVect = tempVect.normalized * speed * time;

        this.gameObject.transform.position += tempVect;

    }
}
