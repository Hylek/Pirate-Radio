using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationMover : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(Vector3.back * 0.35f * Time.deltaTime, ForceMode.Force);
	}
}
