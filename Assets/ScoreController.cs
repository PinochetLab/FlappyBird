using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
	public static int score = 0;
	[SerializeField] Text scoreText;

	private void Start() {
		score = 0;
	}
	private void Update() {
		scoreText.text = score.ToString();
	}

	public static void AddScore() {
		score++;
		if ( PlayerPrefs.HasKey("HighScore") ) {
			PlayerPrefs.SetInt("HighScore", Mathf.Max(score, PlayerPrefs.GetInt("HighScore")));
		}
		else {
			PlayerPrefs.SetInt("HighScore", score);
		}
	}
}
