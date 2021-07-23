using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogic : MonoBehaviour
{

	[SerializeField] GameObject panel;
    public void ShowMenu() {
		panel.SetActive(true);
		Time.timeScale = 0;
	}

	public void HideMenu() {
		panel.SetActive(false);
		Time.timeScale = 1;
	}
}
