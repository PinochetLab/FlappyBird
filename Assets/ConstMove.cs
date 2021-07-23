using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstMove : MonoBehaviour
{
	public float speed = 10f;
	public float yLimit = 3f;
	public float xStart = 5f;
	public float xEnd = -5f;

	private void Start() {
		Set();
	}

	private void Set() {
		transform.position = (Vector3)new Vector2(xStart, Random.Range(-yLimit, yLimit));
	}

	private void Update() {
		transform.position += (Vector3) Vector2.left * speed * Time.deltaTime;
		if ( transform.position.x < xEnd ) Destroy(gameObject);
	}
}
