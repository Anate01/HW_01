using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationBuilder : MonoBehaviour
{
    public Material greenMat;
    public Material redMat;

    void Start()
    {
        GameObject Player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject Enemy = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        Player.name = "Player";
        Enemy.name = "Enemy";

        Player.transform.position = new Vector3(0, 0, 0);
        Enemy.transform.position = new Vector3(0, 3, 0);

        MeshRenderer meshRendererPlayer = Player.GetComponent<MeshRenderer>();
        MeshRenderer meshRendererEnemy = Enemy.GetComponent<MeshRenderer>();
        meshRendererPlayer.material = greenMat;
        meshRendererEnemy.material = redMat;

        Rigidbody rbPlayer = Player.AddComponent<Rigidbody>();
        Rigidbody rbEnemy = Enemy.AddComponent<Rigidbody>();
        rbPlayer.isKinematic = true;
        rbEnemy.drag = 0.5f;

        Player.AddComponent<PlayerMovement>();
        Player.AddComponent<CollideChecker>();
        Enemy.AddComponent<CollideChecker>();
    }


}
