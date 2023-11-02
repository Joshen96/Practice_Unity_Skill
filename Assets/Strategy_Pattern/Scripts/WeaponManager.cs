using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    Myweapon myweapon;
    // Start is called before the first frame update
    void Start()
    {
        myweapon = new Myweapon();
        myweapon.Setweapon(new Bullet());
    }

   public void ChangeBullet()
    {
        myweapon.Setweapon(new Bullet());
    }
    public void ChangeArrow()
    {
        myweapon.Setweapon(new Arrow());
    }
    public void ChangeMissile()
    {
        myweapon.Setweapon(new Missile());
    }
    public void fire()
    {
        myweapon.Shoot();
    }

}
