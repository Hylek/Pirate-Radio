using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startdelay : MonoBehaviour {

	public MonoBehaviour scriptToTurnon;

	// Use this for initialization
	void Start () {
		Invoke ("turnon", 20);
	}
	

	void turnon(){
	
	
		scriptToTurnon.enabled = true;
	
	}


}
