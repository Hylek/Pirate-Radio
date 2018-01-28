using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBoardController : MonoBehaviour {

    public AudioSource audioSource = null;
    public AudioSource omarAudioSource = null;
    public AudioClip clip = null;
    public AudioClip omarTrigger = null;
    public Triggerdoorscript tds;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void PlayDoorSound()
    {
        if(omarAudioSource != null && omarTrigger != null)
        {
            omarAudioSource.clip = omarTrigger;
            omarAudioSource.Play();
        }
    }

    public void PlaySound()
    {
        if(audioSource != null && clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }

    void ViveGripInteractionStart()
    {
        transform.position += new Vector3(0.05f, 0, 0);
        PlaySound();
        PlayDoorSound();
        tds.playerHere = 1;
    }

    void ViveGripInteractionStop()
    {
        transform.position -= new Vector3(0.05f, 0, 0);
    }

}
