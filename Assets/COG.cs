// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// public class COG : MonoBehaviour
// {
//     public Rigidbody rb;
//     public Transform centerOfGravity;
//     public Vector3 inertiaV;
//     // public Quaternion inertiaV2;
//     public float force=10f;
//     private float distance = 5.89f;
//     float angular_vel = 0f;
//     private float timer = 0;
//     private Quaternion target = Quaternion.Euler(0, angular_vel, 0);

// // Start is called before the first frame update
//     void Start()
//     {
        
//         rb.centerOfMass = new Vector3(0,0,0);
        
//     }
//     void FixedUpdate (){
//         rb.inertiaTensor = inertiaV;
//         rb.inertiaTensorRotation = Quaternion.identity;
//         rb.centerOfMass = new Vector3(0,0,0);
//         float torque = force*distance;
//         float radius = 0.5000001f;
//         float mass = 1f;

//         //Ic = (2/5) MR2
//         //Isph = Ic + Md2
//         float inertia =   ((2/5)*mass*radius*radius) + (mass*distance*distance);

//         if (timer == 1){
//             angular_vel += torque/inertia*57.296f;
//             timer = 0;
//             }

//         // Rotate the cube by converting the angles into a quaternion.

//         // Dampen towards the target rotation
//         transform.rotation = Quaternion.Slerp(transform.rotation, target, timer);
//         timer += Time.deltaTime;
//         //rb.AddTorque(transform.up * torque);
//         //rb.angularVelocity = new Vector3(0,1,0)*angular_vel;
            
//     }
// }