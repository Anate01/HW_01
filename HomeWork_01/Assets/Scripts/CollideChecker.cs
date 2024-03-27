using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideChecker : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
    string object1Name = this.name;
    string object2Name = col.gameObject.name;

    Debug.Log($"Collided objects: {object1Name} and {object2Name}");
    }

}
