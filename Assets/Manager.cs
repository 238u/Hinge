using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public float length = 0f;
    public Transform rod;
    public float mass = 1f;
    public Rigidbody ballrb;
    public float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rod.localScale = new Vector3(1,1,2) + new Vector3(0,0,0.2f)*length;
        ballrb.mass = mass;
    }
}
