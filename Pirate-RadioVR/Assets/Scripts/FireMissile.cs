using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour {
	public GlobalScript globalScript;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		if (globalScript.fireMissile == true)
        	GetComponent<Rigidbody>().AddForce(Vector3.forward * 1.0f, ForceMode.Impulse);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.name == "Station")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }
}
