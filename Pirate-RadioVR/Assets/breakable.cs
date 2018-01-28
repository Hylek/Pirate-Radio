using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class breakable : MonoBehaviour
{
    public GameObject[] unlockables;
    public GameObject[] deactivateables;
    public MonoBehaviour[] activateables;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.relativeVelocity.magnitude > 4)
        {


            if (unlockables != null)
            {

                foreach (GameObject item in unlockables)
                {
                    Rigidbody rb = item.GetComponent<Rigidbody>();
                    rb.isKinematic = false;


                }
            }
            if (deactivateables != null)
            {

                foreach (GameObject item in deactivateables)
                {

                    item.SetActive(false);


                }
            }
            if (activateables != null)
            {

                foreach (MonoBehaviour item in activateables)
                {

                    item.enabled = true;


                }
            }
            Debug.Log(gameObject.name + " has been popped by "  + collision.gameObject.name + "with a force of " +collision.relativeVelocity.magnitude);
            Destroy(gameObject);

        }
    }
}
