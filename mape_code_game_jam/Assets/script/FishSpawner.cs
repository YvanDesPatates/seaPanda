using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] prefabs;

    public GameObject player;

	public static float speed;
    // Start is called before the first frame update
    void Start()
    {
        // set speed at 10 on start / restart
		speed = 5f;

        // aysnchronous infinite fish spawning
		StartCoroutine(SpawnFish());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnFish() {
		while (true) {

			// create a new fish from prefab selection at right edge of screen
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(player.transform.position.x + 20 + Random.Range(2, 5), player.transform.position.y - Random.Range(-10, 10), -1),
                Quaternion.identity);

			// wait between 10-15 seconds for a new fish to spawn
			yield return new WaitForSeconds(Random.Range(0, 2));
		}
	}
}
