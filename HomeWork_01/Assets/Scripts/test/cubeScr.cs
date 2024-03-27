using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class cubeScr : MonoBehaviour
{
    public int a = 1;
    public cylinderScr cyl;

    // Start is called before the first frame update
    void Start()
    {
        cyl.b = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
