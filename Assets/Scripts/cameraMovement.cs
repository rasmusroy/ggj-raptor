using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cameraMovement : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    float baseSpeed;

    void Start()
    {
        baseSpeed = GameManager.baseSpeed;

        m_Rigidbody = GetComponent<Rigidbody>();

        m_Rigidbody.velocity = Vector3.forward * baseSpeed;
    }

    void Update()
    {
    }
}
