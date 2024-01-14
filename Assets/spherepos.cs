using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherepos : MonoBehaviour
{
    public Vector3 offpos;
    public Transform orginalsphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = orginalsphere.position - offpos;
    }
}
