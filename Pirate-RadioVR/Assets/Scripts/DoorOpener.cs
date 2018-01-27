using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {
	public Vector3 start;
	public Vector3 end;

	void Start()
	{
		start = transform.position;
		end = start;
		end.y += 2.2f;
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		//transform.Translate (Vector3.up * 0.01f);
		transform.position = Vector3.Lerp (start, end, 0.01f);
	}
}