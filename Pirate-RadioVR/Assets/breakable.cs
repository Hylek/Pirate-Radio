using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakable : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {

        if (collision.relativeVelocity.magnitude > 2)
            Destroy(gameObject);
    }
}
