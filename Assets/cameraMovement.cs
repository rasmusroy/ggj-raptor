using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cameraMovement : MonoBehaviour
{
    public float speed = 4.0f;

    Rigidbody m_Rigidbody;
    float m_Speed;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        m_Speed = speed;

        m_Rigidbody.velocity = Vector3.forward * m_Speed;
    }

    void Update()
    {
    }
}
