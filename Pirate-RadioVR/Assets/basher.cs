using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basher : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("tap");
        Debug.Log(collision.relativeVelocity.magnitude);
        if (collision.relativeVelocity.magnitude > 2)
            Debug.Log("bang");
    }
}
