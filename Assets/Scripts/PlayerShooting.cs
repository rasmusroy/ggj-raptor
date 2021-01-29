using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Transform pfBullet;

    private void Awake()
    {
        GetComponent<PlayerController>().OnFireBulletEvent += PlayerController_OnFireBulletEvent;
    }

    private void PlayerController_OnFireBulletEvent(Transform bulletSpawn)
    {
        Transform bulletTransform = Instantiate(pfBullet, bulletSpawn.position, bulletSpawn.rotation);
    }
}
