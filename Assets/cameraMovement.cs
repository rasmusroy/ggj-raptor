using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cameraMovement : MonoBehaviour
{
    private float baseSpeed;
    
    Rigidbody m_Rigidbody;
    float m_Speed;

    void Start()
    {
        baseSpeed = GameManager.baseSpeed;

        m_Rigidbody = GetComponent<Rigidbody>();

        m_Speed = baseSpeed;

        m_Rigidbody.velocity = Vector3.forward * m_Speed;
    }

    void Update()
    {
    }
}
