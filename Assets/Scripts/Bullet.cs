using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float baseSpeed;
    Rigidbody m_Rigidbody;
    [SerializeField] public float bulletSpeed;

    void Start()
    {
        baseSpeed = GameManager.baseSpeed;

        m_Rigidbody = GetComponent<Rigidbody>();

        m_Rigidbody.velocity = Vector3.forward * (baseSpeed + bulletSpeed);

        // Bullet is destroyed after 5 sec to clean up.
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        
    }

}
