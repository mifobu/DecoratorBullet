using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDamageModifier : BulletModifier
{
    [SerializeField]
    private int bonusDamage;

    public BonusDamageModifier(IDamager modifiedDamager, int bonusDamage) : base(modifiedDamager){
        this.bonusDamage = bonusDamage;
    }

    protected override void modify(){
        modifiedDamager.AddDamage(bonusDamage);
    }
}
