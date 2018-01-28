using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {

    public float speed;
    private float timer = 1.6f;

    private void Update()
    {
        timer -= Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate ()
	{
        if(timer > 0)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
        }
        if(timer <= 0)
        {
            GetComponent<Rigidbody>().Sleep();
        }
	}
}