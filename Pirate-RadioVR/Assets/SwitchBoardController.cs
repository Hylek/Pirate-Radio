using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBoardController : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip godSake;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

    }

    public void PlayGodSake()
    {
        audioSource.clip = godSake;
        audioSource.Play();
    }

    void ViveGripInteractionStart()
    {
        transform.position += new Vector3(0, 0, 0.05f);
    }

    void ViveGripInteractionStop()
    {
        transform.position -= new Vector3(0, 0, 0.05f);
    }

}
