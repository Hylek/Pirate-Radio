using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDoorScript : MonoBehaviour {

    public Vector3 targetHeight;
    private Vector3 startPoint;
    public bool player;

	// Use this for initialization
	void Start () {
        startPoint = transform.position;
        //player = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(startPoint.y < targetHeight.y && player)
        {
            transform.Translate(Vector3.up * 0.03f);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.gameObject.name == "Player")
        {
            player = true;
        }
    }
}
