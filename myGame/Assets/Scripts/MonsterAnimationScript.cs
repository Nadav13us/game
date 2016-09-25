using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MonsterNavigationScript))]
public class MonsterAnimationScript : AnimationScript{

    Animator anim;
    [HideInInspector]public bool attacking = false;
    bool isDead = false;

    public int damage = 6;

    public int destroyTime = 20;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (attacking && !anim.GetCurrentAnimatorStateInfo(1).IsName("attack"))
        {
            GetComponent<MonsterSoundScript>().walkSound();
            anim.SetFloat("speed", 0.2f);
            attacking = false;
        }
    }
   

    public override void attack()
    {
        if(!isDead)
        {
            attacking = true;
            anim.SetTrigger("attacking");
            anim.SetFloat("attacktype", Random.value);
            anim.SetFloat("speed", 0);
            GetComponent<MonsterSoundScript>().attackSound();
        }
    }

    public override void die()
    {
        
        isDead = true;
        anim.SetTrigger("die");
        GetComponent<MonsterSoundScript>().DeathSound();
        GetComponent<MonsterNavigationScript>().enabled = false;
        StartCoroutine(destroyaftertime());
    }

    public IEnumerator destroyaftertime()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision col)
    {
        if(attacking)
        {
            Debug.Log("blaaaa");
            Debug.Log(col.gameObject);
            col.gameObject.GetComponent<HealthScript>().changeHealth(-damage);
        }
    }
}
