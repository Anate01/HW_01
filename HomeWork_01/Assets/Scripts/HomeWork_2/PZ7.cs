using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PZ7 : MonoBehaviour
{
   
    private Person myPers = new Person();
    void Start()
    {
        Debug.Log(myPers.Health);
        myPers.Health = 30;
        Debug.Log(myPers.Health);
        myPers.Health = 300;
        myPers.Health = -300;
        Debug.Log(myPers.Health);

        Debug.Log(myPers.Name);
    }


}


public class Person
{
    private string name = "Tom";
    private int health = 78;

    public string Name
    {
        get
        {
            return name;
        }
    }


    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            if (value < 0 || value > 100) Debug.Log("value is out of range!");
            else health = value; 
        }
    }
}

