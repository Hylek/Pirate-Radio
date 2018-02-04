using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerdoorscript : MonoBehaviour {

    public int playerHere;
    private float timer = 1.6f;

    private Vector3 current;
    public Vector3 open;
    public Vector3 closed;
    private Vector3 targetPos;

	// Use this for initialization
	void Start () {
        //playerHere = 0;
    }

    private void Awake()
    {
        closed = transform.localPosition;
        open = new Vector3(transform.localPosition.x, 2, transform.localPosition.z);
    }

    private void Update()
    {
        timer -= Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate () {

        if(playerHere == 1)
        {
            targetPos = open;
        }
        if(playerHere == 2)
        {
            targetPos = closed;
        }

        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPos, Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.gameObject.name == "Camera (head)")
        {
            playerHere = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.name == "Camera (head)")
        {
            playerHere = 2;
        }
    }
}
