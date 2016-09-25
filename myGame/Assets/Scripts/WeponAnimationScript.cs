using UnityEngine;
using System.Collections;
[RequireComponent (typeof(Animator))]
public class WeponAnimationScript : MonoBehaviour {
    Animator anim;
    [HideInInspector]public bool isAttack = false;
    public int damage = 6;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
       // if (isAttack && anim.GetCurrentAnimatorStateInfo(0).IsName("attack"))
      //  {
      //      isAttack = false;
    //        GetComponent<BoxCollider>().enabled = false;
      //  }
    }

    void OnCollisionEnter(Collision col)
    {
         //Debug.Log(col.gameObject);
       // Debug.Log(isAttack);
        if (isAttack && col.gameObject.tag == "enemy")
        {
            col.gameObject.GetComponent<HealthScript>().changeHealth(-damage);
    //        GetComponent<WeponAudioScript>().playHitSound();
            
        }
    }

    public void attack()
    {
       // GetComponent<WeponAudioScript>().playSwingSword();
    //    GetComponent<BoxCollider>().enabled = true;   
        anim.SetFloat("Blend", Random.value);
        anim.SetTrigger("attacking");
       // isAttack = true;
       // Debug.Log("WORK!");//didnt work T_T
    }
}
