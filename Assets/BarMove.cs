using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMove : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel;
        vel = Vector3.zero;
      if(Input.GetKey(KeyCode.RightArrow))
        {
            //  rb.AddForce(5, 0, 0, ForceMode.Impulse);
            vel.x = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // rb.AddForce(-5, 0, 0, ForceMode.Impulse);
            vel.x = -1;
        }
        rb.velocity = vel * 10;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Retry")
        {
            print("hit");
        }
    }
}
