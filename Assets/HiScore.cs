using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScore : MonoBehaviour
{
	Text text;

	private void Awake() {
		text = GetComponent<Text>();
	}

	private void Update() {
		if ( PlayerPrefs.HasKey("HighScore") ) text.text = PlayerPrefs.GetInt("HighScore").ToString();
		else text.text = "0";
	}
}
