using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class LuneObject
{
    private float angleDepart;
    private float distanceJup;
    private Vector3 position;
    private Color color;
    public LuneObject(float angleDepart, float distanceJup,int colorRnd)
    {
        Random.InitState(colorRnd);
        
        this.angleDepart = angleDepart;
        this.distanceJup = distanceJup;
        Debug.Log("test");
        Debug.Log(angleDepart);
        this.setMyPosition();
        color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
    }
    // Start is called before the first frame update
    //valeur entre 0 et 360
    
    
    public void setMyPosition()
    {
        
        float x = (float)Math.Cos(angleDepart  * Math.PI)*distanceJup;
        float z = (float)Math.Sin(angleDepart  * Math.PI)*distanceJup;
        this.position = new Vector3(x,0f,z);
    }

    public Vector3 getPosition()
    {
        return position;
    }

    public Color getColor()
    {
        return color;
    }
}
