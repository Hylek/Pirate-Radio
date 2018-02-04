using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetWobble : MonoBehaviour {
    public GameObject parent;
    public Vector3 offset;
    public float LerpSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = parent.transform.position;

        transform.rotation = Quaternion.Lerp(transform.rotation, parent.transform.rotation * Quaternion.Euler(offset), Time.time * LerpSpeed);


    }
}
