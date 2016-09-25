using UnityEngine;
using System.Collections;

public class monsterHitPlayer : MonoBehaviour {
    MonsterAnimationScript animationScript;
	// Use this for initialization
	void Start () {
        animationScript = transform.parent.gameObject.GetComponent<MonsterAnimationScript>();
	}
    void OnCollisionEnter(Collision col)
    {
        //Debug.Log(animationScript.attacking);
        if (col.gameObject.tag == "Player" && animationScript.attacking)
        {
           // Debug.Log("gal galino gal gal leno galeno galeno galeno");
            animationScript.hit(col.gameObject);
        }
    }


    // Update is called once per frame
    void Update () {
	
	}
}
