using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdDeath : MonoBehaviour, IKillable
{
    public void Kill() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
