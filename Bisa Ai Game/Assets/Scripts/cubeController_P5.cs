using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController_P5 : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float h;
    float v;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //  rb.velocity = new Vector3(0,0,speed);
    }
    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(h * speed, rb.velocity.y, v * speed);
    }

}
