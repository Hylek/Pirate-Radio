using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handrail : MonoBehaviour {

    private ViveGrip_ControllerHandler controller;

    public bool X, Y, Z; //can translate in these directions;
    private float xpos, ypos, zpos;
    private bool grabbed;
    public GameObject playerrig;
    private Vector3 originalControllerPos;
    private Vector3 newControllerPos;
    public AudioSource sound2play;

    // Use this for initialization
    void Start () {
		
	}


    void ViveGripGrabStart(ViveGrip_GripPoint gripPoint)
    {
        controller = gripPoint.controller;
        grabbed = true;
        originalControllerPos = controller.transform.position;

        if (sound2play != null)
        {
            sound2play.enabled = true;
        }

    }

    void ViveGripGrabStop()
    {
        controller = null;
        grabbed = false;
       // originalControllerPos = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update () {
		
        if (grabbed)
        {
            newControllerPos = controller.transform.position;
            Vector3 moveamt = originalControllerPos - newControllerPos;
            xpos = playerrig.transform.position.x;
            ypos = playerrig.transform.position.y;
            zpos = playerrig.transform.position.z;



            if (X)
            {
                xpos = playerrig.transform.position.x + moveamt.x;
            }
            if (Y)
            {
                ypos = playerrig.transform.position.y + moveamt.y;
            }
            if (Z)
            {
                zpos = playerrig.transform.position.z + moveamt.z;
            }

            playerrig.transform.position = new Vector3(xpos, ypos, zpos);

        }


	}
}
