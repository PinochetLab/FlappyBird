using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanKill : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision) {
		print("lol");
		collision.GetComponent<IKillable>()?.Kill();
	}
}
