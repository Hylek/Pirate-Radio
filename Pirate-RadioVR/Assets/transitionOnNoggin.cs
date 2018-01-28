using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitionOnNoggin : MonoBehaviour {

    public MonoBehaviour transitioningscript;




        void OnCollisionEnter(Collision collision)
    {

        transitioningscript.enabled = true;



    }

    }


