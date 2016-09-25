using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]
public class MonsterSoundScript : MonoBehaviour {
    public AudioClip walk;
    public AudioClip attack;
    public AudioClip dead;
    AudioSource source;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void walkSound()
    {
        source.loop = true;
        source.clip = walk;
        source.Play();
    }
    public void attackSound()
    {

        source.loop = true;
        source.clip = attack;
        source.Play();
    }
    public void DeathSound()
    {
        source.loop = false;
        source.clip = dead;
        source.Play();
    }



}
