using UnityEngine;
using System.Collections;

[CreateAssetMenu (menuName ="new Weapon")]
public class WeaponObject : ScriptableObject
{
    public int dmg;

    public GameObject WeaponPrefab;

    public bool canUse;
}
