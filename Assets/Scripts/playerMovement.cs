using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playerMovement : MonoBehaviour
{
    private float baseSpeed;
    public float speed = 1f;
    private float translation;
    private float strafe;

    Rigidbody m_Rigidbody;

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
    }
}
