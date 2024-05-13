using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Gun
{
    [SerializeField] GameObject prefabShotGunBlast;
    public override bool AttemptFire()
    {
        if (!base.AttemptFire())
            return false;

        var b = Instantiate(bulletPrefab, gunBarrelEnd.transform.position, gunBarrelEnd.rotation);
        b.GetComponent<Projectile>().Initialize(15, 100, 3, 20, null); // version without special effect
        //b.GetComponent<Projectile>().Initialize(1, 100, 2, 5, DoThing); // version with special effect

        Instantiate(prefabShotGunBlast, gunBarrelEnd.transform.position, transform.rotation);

        anim.SetTrigger("shoot");
        elapsed = 0;
        ammo -= 1;

        return true;
    }
}
