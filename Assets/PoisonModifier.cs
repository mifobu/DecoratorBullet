
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PoisonModifier : BulletModifier
{
    private int poisonDamage;
    private int poisonDuration;


    public PoisonModifier(IDamager modifierDamager, int poisonDamage, int poisonDuration) : base(modifiedDamager) {
        this.poisonDamage = poisonDamage;
        this.poisonDuration = poisonDuration;
    }

    protected override void modify(){
        //FindObjectOfType<bulletVictim>().receiveDamageOverTime(poisonDamage, poisonDuration);
        bulletVictim.receiveDamageOverTime(poisonDamage, poisonDuration);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

