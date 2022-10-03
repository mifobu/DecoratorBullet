using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class DamageableObject : MonoBehaviour, IDamageable 
{
    [SerializeField] private int HP;
    private WaitForSeconds waitOneSecond = new WaitForSeconds(1);

    public void receiveDamage(int damage) {
        HP -= damage;
    }

    public void receiveDamageOverTime (int damage, int duration) {
        StartCoroutine(DamageOverTime(damage, duration));
    }

    private IEnumerator DamageOverTime(int damage, int duration) {
        for (int i=0; i < duration; i++) {
            yield return waitOneSecond;
            HP -= damage;
        }
    }

    void OnTriggerEnter(Collider coll) {
        Bullet b = coll.GetComponent<Bullet>();
        if (b) {
            b.inflictDamage(this);
        }
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
