using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AEasyMainMenuScript : MonoBehaviour {

	private int score;

	// Load Scene 01 when start button is pressed
	public void StartGame()
	{
		PlayerPrefs.SetInt ("AEasyScore",score);
		SceneManager.LoadScene ("AEasy01");
	}

	// Load Trophy Room scene when trophy room button is pressed
	public void GotoTrophyRoom()
	{
		SceneManager.LoadScene ("AEasyTrophyRoom");
	}

	// Reset All Player Preferences data to start earn trophies again
	public void ResetPlayerPrefs()
	{
		PlayerPrefs.DeleteAll ();
	}

}
