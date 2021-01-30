using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    private float translation;
    private float strafe;
    Rigidbody m_Rigidbody;

    float baseSpeed;

    [SerializeField] public Transform bulletSpawn;

    public event OnFireBulletDelegate OnFireBulletEvent;
    public delegate void OnFireBulletDelegate(Transform bulletSpawn);

    void Start()
    {
        baseSpeed = GameManager.baseSpeed;

        m_Rigidbody = GetComponent<Rigidbody>();

        m_Rigidbody.velocity = Vector3.forward * baseSpeed;
    }

    void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        strafe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(strafe, 0, translation);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            OnFireBulletEvent?.Invoke(bulletSpawn);
        }
    }
}
