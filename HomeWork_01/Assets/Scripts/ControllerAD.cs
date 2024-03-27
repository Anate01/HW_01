using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAD : MonoBehaviour
{
    [SerializeField] private float moveSpeed;


    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f * moveSpeed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f * moveSpeed, 0f, 0f);
        }
    }



}
