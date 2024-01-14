using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torque : MonoBehaviour
{
    public Rigidbody rb;
    //public GameObject system;
    //public Manager manager;
    public float force = 2000f;
    public float radius = 0.5000001f;
    public float mass = 1f;
    public float distance = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb.centerOfMass = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        float torque = force*distance;


        //Ic = (2/5) MR2
        //Isph = Ic + Md2
        float inertia =   ((2/5)*mass*radius*radius) + (mass*distance*distance);
        float angular_vel = torque/inertia;
        //ftorque = manager.force*manager.length;
        //rb.AddTorque(transform.up*ftorque);
        rb.angularVelocity = new Vector3(0,1,0)*angular_vel;
        Debug.Log(angular_vel);
    }
}
