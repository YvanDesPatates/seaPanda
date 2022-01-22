using UnityEngine;
using System.Collections;

public class Algue : MonoBehaviour {

    public static int nbAlgues = 0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {

		// trigger coin pickup function if a helicopter collides with this
		nbAlgues++;
		Destroy(gameObject);
	}
}
