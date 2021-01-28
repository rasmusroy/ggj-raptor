using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playerMovement : MonoBehaviour
{
    public float baseSpeed = 4.0f;
    public float speed = 1f;
    private float translation;
    private float straffe;

    Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        m_Rigidbody.velocity = Vector3.forward * baseSpeed;
    }

    void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);
    }
}
