using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[RequireComponent (typeof(HealthScript))]
[RequireComponent (typeof(BoxCollider))]
public class PlayerAnimationScript : AnimationScript
{
    Animator anim;
    public List<WeaponObject> weapons;
    int activeWeapon = 0;
    WeponAnimationScript weaponScript;
    
    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        GameObject weaponObject = Instantiate(weapons[activeWeapon].WeaponPrefab) as GameObject;
        weaponObject.transform.parent = transform.GetChild(0);
        weaponScript = weaponObject.GetComponent<WeponAnimationScript>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0) && !weaponScript.isAttack)
        {
           // Debug.Log("whyyyyyy");
            attack();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && weapons.Count>=1)
        {
            switchWepon(0);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)&&weapons.Count >= 2)
        {
            switchWepon(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)&&weapons.Count >= 3)
        {
            switchWepon(2);
        }
    }

    public override void attack()
    {
        weaponScript.attack();
    }

    public override void die()
    {
        Debug.Log("you are dead T_T");
    }

   void switchWepon(int index)
    {
        Destroy(weaponScript.gameObject);
        activeWeapon = index;
        GameObject weaponObject = Instantiate(weapons[activeWeapon].WeaponPrefab) as GameObject;
        weaponObject.transform.parent = transform.GetChild(0);
        weaponScript = weaponObject.GetComponent<WeponAnimationScript>();
    }
}
