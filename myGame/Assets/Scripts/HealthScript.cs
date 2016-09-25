using UnityEngine;
using System.Collections;
using System;

//[RequireComponent (typeof (AnimationScript))]
public class HealthScript : MonoBehaviour {
    public int maximumHealth = 100; 
    public int correntHealth = 100;

    bool flag=true;

    AnimationScript animation;

    void Start()
    {
        animation = GetComponent<AnimationScript>();
    }

    void Update()
    {
        if (flag && correntHealth <= 0)
        {
            flag = false;
            animation.die();
        }
    }

    public void changeHealth(int change)
    {
        correntHealth = Math.Min(correntHealth + change, maximumHealth);
    }
}
