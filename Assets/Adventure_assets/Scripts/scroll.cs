using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
public Material m;
public float x,y = 0.5f;
public void Start()
    {
         m = gameObject.GetComponent<Renderer>().material;
    }
 
    void Update()
    {
         x += Time.deltaTime * .5f;
         y += Time.deltaTime * .25f;
         if(x>1){x-=1;}if(y>0.5){y-=1;}
     
         m.mainTextureOffset = new Vector2 (x, y);
 
    }
}