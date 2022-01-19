using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawneur : MonoBehaviour
{
    [SerializeField]private GameObject spherePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spherePrefab,
            new Vector3(0f,0f,0f),Quaternion.identity);
        
        Instantiate(spherePrefab,new Vector3(0f,0f,0f),Quaternion.identity);
        Instantiate(spherePrefab,new Vector3(0f,0f,0f),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
