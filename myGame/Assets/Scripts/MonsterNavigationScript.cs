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
        
        agent1.SetDestination(new Vector3(target.position.x -3, target.position.y-2, target.position.z));
        if (Vector3.Distance(target.position, transform.position) < 4.5f && !anim.attacking)
        {
            anim.attack();
        }
          
    }
}
