using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
	public IControllable _icontrollable;

	private void Awake() {
		_icontrollable = GetComponent<IControllable>();
	}

	private void Update() {
		_icontrollable.ControlLogic();
	}
}
