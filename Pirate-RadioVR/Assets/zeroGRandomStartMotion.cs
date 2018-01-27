using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class zeroGRandomStartMotion : MonoBehaviour {

    Rigidbody RB;

	// Use this for initialization
	void Start () {

        Vector3 fudge = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f));

        RB = GetComponent<Rigidbody>();



        RB.AddForce(fudge);
        RB.AddTorque(fudge);
	}
	

}
