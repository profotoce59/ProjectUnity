using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePhysicController : MonoBehaviour
{
    [SerializeField]private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector3(1f,0f,0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
