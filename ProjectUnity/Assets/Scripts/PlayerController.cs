using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_WalkSpeed = 1.0f;
    private Rigidbody m_Rigidbody;
    private Vector3 m_WalkDir = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            m_WalkDir = Camera.main.transform.forward;
        }
        else
        {
            m_WalkDir = Vector3.zero; //if no input dont walk
        }
    }

    private void FixedUpdate()
    {
        if (m_Rigidbody == null)
            return;

        m_Rigidbody.MovePosition(transform.position + m_WalkDir * m_WalkSpeed * Time.fixedDeltaTime);
    }
}
