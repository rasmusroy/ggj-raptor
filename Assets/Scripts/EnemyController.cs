using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private HealthSystem healthSystem = new HealthSystem(10);

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Bullet>().OnBulletDamageEvent += Bullet_OnBulletDamageEvent;
    }

    private void Bullet_OnBulletDamageEvent(int bulletDamage)
    {
        healthSystem.Damage(bulletDamage);
        Debug.Log(healthSystem.GetHealth());
        if (healthSystem.GetHealth() <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
