using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed = 5f;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
         rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        // transform.Translate(Input.GetAxis("Horizontal") * Speed, 0, Input.GetAxis("Vertical") * Speed);
    }

    void FixedUpdate()
    {
        rb.AddForce(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * Speed);
    }
}
