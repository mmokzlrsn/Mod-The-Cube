using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
   


    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one * Random.Range(1f, 3f);
        Material material = Renderer.material;


        material.color = new Color(colorRand(), colorRand(), colorRand(), colorRand());
        
    }
    
    void Update()
    {
        
        transform.Rotate(speedRand() * Time.deltaTime, speedRand() * Time.deltaTime, speedRand() * Time.deltaTime);
        
    }

    float colorRand()
    {
        return Random.Range(0, 1f);
    }
    float speedRand()
    {
        return Random.Range(0, 300f);
    }
}
