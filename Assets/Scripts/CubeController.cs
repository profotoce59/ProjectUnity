using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]public float speed;
    // Start is called before the first frame update
    private Vector3 direction = new Vector3(0f, 0f, 1f);
    private float timer;
    void Start()
    {
        Debug.Log("test");
        timer = 0f;
        StartCoroutine(nameof(UpdateDirection));
    }

    // Update is called once per frame
    void Update()
    {
        if (direction.z == 1)
        {
            transform.position += new Vector3(0f, 0f, 0.01f) * speed;
        }
        else transform.position -= new Vector3(0f, 0f, 0.01f) * speed;

        
    }

    IEnumerator UpdateDirection()
    {// coRoutine ne reste pas blocké à l'intérieur
        while (true)
        {
            yield return new WaitForSeconds(5f); // attend 5 seconds à chaque fois
            direction.z = -direction.z;
            Debug.Log(direction.z);
        }
    }
}
