using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour, IWeapon
{
    public void Shoot(GameObject obj)
    {
        Debug.Log("미사일 공격");
        
        Vector3 initialPosition = new Vector3(transform.position.x, transform.position.y, 0);
        GameObject missile = Instantiate(obj) as GameObject;
        missile.transform.position = initialPosition;
    }
}
