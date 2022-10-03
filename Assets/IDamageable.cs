using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable {
    void receiveDamage(int damage);
    void receiveDamageOverTime(int damage, int duration);
}
