using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class breakable : MonoBehaviour
{
    public GameObject[] unlockables;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.relativeVelocity.magnitude > 2)
        {


            if (unlockables != null)
            {

                foreach (GameObject item in unlockables)
                {
                    Rigidbody rb = item.GetComponent<Rigidbody>();
                    rb.isKinematic = false;


                }
            }

            Destroy(gameObject);

        }
    }
}
