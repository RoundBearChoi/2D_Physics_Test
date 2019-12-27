using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceAndTorque : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public float RightForce;
    public float Torque;

    void Start()
    {
        rigidbody2d = this.gameObject.GetComponent<Rigidbody2D>();

        rigidbody2d.AddTorque(Torque);
        rigidbody2d.AddForce(Vector2.right * RightForce);
    }
}
