using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed;
    public int jumpspeed;
    private Rigidbody rb;
    private bool grounded;
    public int rotateSpeed;

    void OnCollisionEnter(Collision c){
      if(c.gameObject.tag == "ground"){
        grounded = true;
      }
    }
    // Start is called before the first frame update
    void Start()
    {
      rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      float mx = Input.GetAxisRaw("Horizontal");
      float mz = Input.GetAxisRaw("Vertical");
      float ry = Input.GetAxis("Mouse X");
      transform.Rotate(Vector3.up * ry * rotateSpeed);
      if(Input.GetKeyDown(KeyCode.Space) && grounded){
        rb.velocity = Vector3.up * jumpspeed;
        grounded = false;
      }else{
        rb.velocity = new Vector3(0f, rb.velocity.y, 0f);
      }
      rb.velocity += transform.forward * mz * speed;
      rb.velocity += transform.right * mx * speed;
    }
}
