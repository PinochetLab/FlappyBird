using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
	[SerializeField] float period = 1f;
	[SerializeField] GameObject pipe;
	float time = 0;
	private void Update() {
		time += Time.deltaTime;
		if (time > period ) {
			Spawn();
			time = 0;
		}
	}

	void Spawn() {
		Instantiate(pipe);
	}
}
