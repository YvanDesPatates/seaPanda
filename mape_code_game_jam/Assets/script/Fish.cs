using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fish : MonoBehaviour
{
    private float positionOnStart;
    private float zAngle;
    private Vector3 targetPos;
    private int z;

    public Transform cible;

    void Start()
    {
        zAngle = Random.Range(-10, 10);
        transform.Rotate(0, 0, zAngle);
    }

    void Update()
    {
        z = Random.value < 0.55 ? 1 : -1;
        transform.Rotate(0, 0, z);
        Vector3 dir = cible.position - transform.position;
        transform.Translate(dir.normalized * FishSpawner.speed * Time.deltaTime, Space.World);
        targetPos = cible.position;
        transform.right = cible.position - transform.position;
        cible.position = targetPos;

        if (transform.position.x < positionOnStart - 50)
        {
            Destroy(gameObject);
        }
    }
}
