using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LuneSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    private List<LuneObject> luneList = new List<LuneObject>();
    [SerializeField]public int luneNumber = 5;
    [SerializeField]public GameObject jupiter;
    [SerializeField]public GameObject lunePrefab;
    private List<Tuple<Transform,Vector3>> centerList = new List<Tuple<Transform,Vector3>>();
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);

        for (int i = 0; i < luneNumber; i++)
        {
            LuneObject a = new LuneObject(Random.Range(0f, 360f),15,Random.Range(0,100));
            luneList.Add(a);
            
        }

        foreach (LuneObject lune in luneList)
        {
            var center = Instantiate(jupiter.transform);
            Instantiate(lunePrefab,lune.getPosition(),Quaternion.identity,center);
            Vector3 rotation = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            centerList.Add(new Tuple<Transform, Vector3>(center,rotation));
        }
        

        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var center in centerList)
        {
            center.Item1.Rotate(center.Item2);
        }
           
      

        
    }
}
