using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitionOnNoggin : MonoBehaviour {

    public MonoBehaviour transitioningscript;

    public GameObject eye;

    private void FixedUpdate()
    {
        if (eye.transform.position.y > 2)
        {
            transitioningscript.enabled = true;
        }
    }


    void OnCollisionEnter(Collision collision)
    {

        transitioningscript.enabled = true;



    }

    }


