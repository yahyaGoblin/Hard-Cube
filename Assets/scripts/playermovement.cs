using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //this adds forward force
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        
        //this checks is key is pressed and adds force to object in specified axis
        if (Input.GetKey("d"))
        {
            rb.AddForce (sidewaysForce * Time.deltaTime , 0 ,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce (-sidewaysForce * Time.deltaTime , 0 ,0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<game_manager>().EndGame();
        }

    }
}
