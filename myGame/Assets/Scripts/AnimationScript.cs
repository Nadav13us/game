using UnityEngine;
using System.Collections;

public abstract class AnimationScript : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public abstract void attack();
    public abstract void die();
}
