using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fish : MonoBehaviour
{
    private float positionOnStart;

    private float yDirection;

    // Start is called before the first frame update
    void Start()
    {
        positionOnStart = transform.position.x;
        yDirection = Random.Range(-1, 2);;
    }

    // Update is called once per frame
    void Update()
    {
        // despawn when past left edge of the screen (camera)
		if (transform.position.x < positionOnStart - 50) {
			Destroy(gameObject);
		}
		// scroll based on FishSpawner static variable, speed
		transform.Translate(-FishSpawner.speed * Time.deltaTime, FishSpawner.speed / 2 * yDirection * Time.deltaTime, 0);
	}
}
