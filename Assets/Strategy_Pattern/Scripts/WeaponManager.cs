using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum WeaponType
{
    Bullet,
    Arrow,
    Missile
}
public class WeaponManager : MonoBehaviour
{
    public GameObject _arrow;
    public GameObject _bullet;
    public GameObject _missile;

    private GameObject MyWeapon;

    private IWeapon weapon;

    private void setWeaponType(WeaponType _weapontype)
    {
        Component c = gameObject.GetComponent<IWeapon>() as Component;

        if (c != null)
        {
            Destroy(c);
        }
        switch (_weapontype)
        {
            case WeaponType.Bullet:
               weapon= gameObject.AddComponent<Bullet>();
                MyWeapon = _bullet;
                break;
            case WeaponType.Arrow:
               weapon = gameObject.AddComponent<Arrow>();
                MyWeapon = _arrow;
                break;
            case WeaponType.Missile:
                weapon = gameObject.AddComponent<Missile>();
                MyWeapon = _missile;
                break;
            default:
               weapon = gameObject.AddComponent<Bullet>();
                MyWeapon = _bullet;
                break;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        setWeaponType(WeaponType.Bullet);
    }

   public void ChangeBullet()
    {
        setWeaponType(WeaponType.Bullet);
    }
    public void ChangeArrow()
    {
        setWeaponType(WeaponType.Arrow);
    }
    public void ChangeMissile()
    {
        setWeaponType(WeaponType.Missile);
    }
    public void fire()
    {
        weapon.Shoot(MyWeapon);
    }

}
