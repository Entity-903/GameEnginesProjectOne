using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : MonoBehaviour
{
    [SerializeField] float turnRate = 90f;
    [SerializeField] float maxSpeed = 5f;
    [SerializeField] GameObject rocket;

    float torque;
    float force;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        torque = Input.GetAxis("Horizontal") * turnRate;
        force = Input.GetAxis("Vertical") * maxSpeed;

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(rocket, transform.position + Vector3.up, transform.rotation);
        }
    }

	private void FixedUpdate()
	{
        rb.AddRelativeForce(Vector3.forward * force);
        rb.AddRelativeTorque(Vector3.up * torque);
	}
}
