using UnityEngine;
using System.Collections;

public class WeponAudioScript : MonoBehaviour {

    public AudioClip hitClip;
    public AudioClip swingClip;
    AudioSource source;

	// Use this for initialization
	void Start ()
    {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    public void playSwingSword()
    {
        source.PlayOneShot(swingClip);
    }

    public void playHitSound()
    {
        source.PlayOneShot(hitClip);
    }
}
