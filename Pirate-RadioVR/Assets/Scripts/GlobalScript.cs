using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour {
	public static GlobalScript instance = null;
	public int switchesToPull = 3;
	public bool fireMissile = false;

	/*private void Awake() {
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);
	}*/

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (switchesToPull <= 0)
		{
			// Cut the power!
		}
	}
}
