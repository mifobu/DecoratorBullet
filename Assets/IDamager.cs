using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamager {
    void inflictDamage(IDamageable victim);
    void AddDamage(int bonusDamage);
}