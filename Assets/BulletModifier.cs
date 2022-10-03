using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class BulletModifier : IDamager 
{
    protected IDamager modifiedDamager;
    protected IDamageable bulletVictim;

    public BulletModifier(IDamager modifiedDamager){
        this.modifiedDamager = modifiedDamager;
    }

    public void inflictDamage(IDamageable victim){
        if (!modifiedDamager.Equals(null)){
            bulletVictim = victim;
            modify();
        }
    }

    protected abstract void modify();

    public void AddDamage(int bonusDamage){
        
    }
}
