using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COGspehere : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.centerOfMass = new Vector3(0,0,0);
    }
}
