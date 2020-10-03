using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(3, 0, -10, ForceMode.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
      if(rb.velocity.magnitude<10)
        {
            rb.AddForce(rb.velocity.normalized * 10);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Retry")
        {
            print("hit");
            transform.position = new Vector3(0, 1, -3.5f);
            rb.velocity = new Vector3(0, 0, 0);
            Vector3 ran;
            ran.x = Random.Range(-1.0f, 1.0f);
            ran.z = Random.Range(-1.0f, 1.0f);
            ran.y = 0;
            ran = ran.normalized;
            rb.AddForce(ran*11, ForceMode.Impulse);
        }
    }
}
