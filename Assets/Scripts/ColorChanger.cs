using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        Light light = GetComponent<Light>();
        light.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
