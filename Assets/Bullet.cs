using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet : MonoBehaviour, IDamager
{
    [SerializeField] private int damage;
    private List<BulletModifier> myModifiers = new List<BulletModifier>();

    public void inflictDamage(IDamageable victim) {
        for (int i = 0; i<myModifiers.Count; i++){
            myModifiers[i].inflictDamage(victim);
        }
        victim.receiveDamage(damage);
    }

    void Start (){
        RegisterBulletModifier(new BonusDamageModifier(this, 40));
        RegisterBulletModifier(new PoisonModifier(this, 5, 4));
    }

    void Update (){

    }

    public void AddDamage( int extraDamage){
        damage += extraDamage;

    }

    public void RegisterBulletModifier(BulletModifier newModifier){
        myModifiers.Add(newModifier);
    }
}
        
