using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePlus : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other) {
		IControllable icontrollable = other.GetComponent<IControllable>();
		if ( icontrollable != null ) {
			ScoreController.AddScore();
			Destroy(gameObject);
		}
	}
}
