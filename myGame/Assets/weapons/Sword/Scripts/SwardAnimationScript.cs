using UnityEngine;
using System.Collections;

public class SwardAnimationScript : MonoBehaviour
{
	int attackingHash = Animator.StringToHash("attacking");
	int hitHash = Animator.StringToHash("hit");

	public AudioClip swordSwing;
	public AudioClip swordCling;

	private AudioSource source;

	Animator anim;

	// Use this for initialization
	void Start ()
	{
		source = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetMouseButtonDown(0))
		{
			source.PlayOneShot(swordSwing, 1f);
			anim.SetFloat("Blend", Random.value);
			anim.SetTrigger(attackingHash);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		source.PlayOneShot(swordCling, 1f);
		//Debug.Log("collision");
		anim.SetTrigger(hitHash);
	}

}
