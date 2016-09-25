using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class MonsterNavigationScript: MonoBehaviour {

    public Transform target;
    NavMeshAgent agent1;
    MonsterAnimationScript anim;
    
    // Use this for initialization
    void Start()
    {
        agent1 = GetComponent<NavMeshAgent>();
        anim = GetComponent<MonsterAnimationScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
       
        if (Vector3.Distance(target.position, transform.position) < 7 && !anim.attacking)
        {
            agent1.enabled = false;
            anim.setSpeed(0);

            anim.attack();
        }
        else
        {
            agent1.enabled = true;
            anim.setSpeed(0.2f);
            agent1.SetDestination(new Vector3(target.position.x, target.position.y, target.position.z));
        }
          
    }
}
