using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PZ7_2 : MonoBehaviour
{
    private Player myPlayer = new Player();

    void Start()
    {
        Debug.Log("My Player health " + myPlayer.Health);
        Debug.Log("My Player exp " + myPlayer.Exp);

        myPlayer.ShowStat(); /////////// PZ 7_3
    }

}


public class Player : Person
{
    private int exp = 0;

    public int Exp
    {
        get
        {
            return exp;
        }
        private set
        {
            exp = value; 
        }
    }

    public override void ShowStat()   /////////// PZ 7_3
    {
        base.ShowStat();
        Debug.Log("Stat: " + exp);
    }
}