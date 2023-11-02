using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myweapon 
{
    private IWeapon weapon;

    public void Setweapon(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public void Shoot()
    {
        weapon.Shoot();
    }
}
