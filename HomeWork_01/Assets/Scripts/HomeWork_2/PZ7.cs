using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PZ7 : MonoBehaviour
{
   
    private Person myPers = new Person();
    void Start()
    {
        Debug.Log("My Person health " + myPers.Health);
        myPers.Health = 30;
        Debug.Log("My Person health " + myPers.Health);
        myPers.Health = 300;
        myPers.Health = -300;
        Debug.Log("My Person health " + myPers.Health);

        Debug.Log("My Person name " + myPers.Name);
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
        private set
        {
            name = value; 
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

    public virtual void ShowStat()   /////////// PZ 7_3
    {
        Debug.Log("Stat: " + name);
    }


}

