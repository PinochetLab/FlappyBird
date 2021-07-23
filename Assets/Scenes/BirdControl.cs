using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour, IControllable
{
	[SerializeField] float jumpSpeed;
	Rigidbody2D rb;

	private void Awake() {
		rb = GetComponent<Rigidbody2D>();
	}
	public void ControlLogic() {
		if ( Input.GetMouseButtonDown(0) ) {
			Jump();
		}
	}

	void Jump() {
		rb.velocity = Vector2.up * jumpSpeed;
	}
}
