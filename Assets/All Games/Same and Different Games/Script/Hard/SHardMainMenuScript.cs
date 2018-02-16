using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SHardMainMenuScript : MonoBehaviour {

	private int score;

	// Load Scene 01 when start button is pressed
	public void StartGame()
	{
		int index = randomize ();
		PlayerPrefs.SetInt ("SHardScore",score);
		SceneManager.LoadScene (index);
	}

	// Load Trophy Room scene when trophy room button is pressed
	public void GotoTrophyRoom()
	{
		SceneManager.LoadScene ("SHardTrophyRoom");
	}

	// Reset All Player Preferences data to start earn trophies again
	public void ResetPlayerPrefs()
	{
		PlayerPrefs.DeleteAll ();
	}

	int randomize() {
		int index = Random.Range (243, 272);
		return index;
	}

}
