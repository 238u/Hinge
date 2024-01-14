using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COGw : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Transform centerOfGravity;
    public float force=10f;
    private float distance = 5.89f;
// Start is called before the first frame update
    void Start()
    {
        
        //rb.centerOfMass = centerOfGravity.localPosition;
    }
    void FixedUpdate (){
        float v = force*distance;
        rb.AddTorque(new Vector3(0,v,0));
    }
}
