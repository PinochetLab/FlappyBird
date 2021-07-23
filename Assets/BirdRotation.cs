using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdRotation : MonoBehaviour
{
	Rigidbody2D rb;
	[SerializeField] float rotSpeed = 200;

	private void Awake() {
		rb = GetComponent<Rigidbody2D>();
	}


	private void Update() {
		Vector2 target = (Vector2.right + Vector2.up * Mathf.Sign(rb.velocity.y)).normalized;
		transform.right = Vector3.Lerp(transform.right, target, rotSpeed * Time.deltaTime).normalized;
	}
}
