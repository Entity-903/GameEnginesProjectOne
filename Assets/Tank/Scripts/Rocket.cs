using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float force = 50f;
    void Start()
    {
        // Rocket is spawned in, but does not go anywhere
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force, ForceMode.VelocityChange);
    }

    void Update()
    {
        
    }
}
