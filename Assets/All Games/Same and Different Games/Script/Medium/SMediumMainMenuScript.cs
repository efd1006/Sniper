﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SMediumMainMenuScript : MonoBehaviour {

	private int score;

	// Load Scene 01 when start button is pressed
	public void StartGame()
	{
		int index = randomize ();
		PlayerPrefs.SetInt ("SMediumScore",score);
		SceneManager.LoadScene (index);
	}

	// Load Trophy Room scene when trophy room button is pressed
	public void GotoTrophyRoom()
	{
		SceneManager.LoadScene ("SMediumTrophyRoom");
	}

	// Reset All Player Preferences data to start earn trophies again
	public void ResetPlayerPrefs()
	{
		PlayerPrefs.DeleteAll ();
	}

	int randomize() {
		int index = Random.Range (275, 304);
		return index;
	}

}
