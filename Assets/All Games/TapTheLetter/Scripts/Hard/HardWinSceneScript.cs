using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HardWinSceneScript : MonoBehaviour {

	public Text scoreText;
	private int score;
	string insertScoreUrl = "https://apisniper.000webhostapp.com/API/insertscore.php";

	// Use this for initialization
	void Start () {

		scoreText.text = "Score: " + PlayerPrefs.GetInt ("HardScore");
		StartCoroutine (insertToDB(PlayerPrefs.GetInt ("HardScore")));
		// Invoke GotoMainMenu method in 1 second
		Invoke ("GotoMainMenu", 1f);
	}

	// Load MainMenu scene
	void GotoMainMenu()
	{
		PlayerPrefs.SetInt ("QuestionNum", 0);
		SceneManager.LoadScene ("MainMenuHard");
	}
	IEnumerator insertToDB(int score)
	{
		WWWForm form = new WWWForm();
		form.AddField ("score", score);
		form.AddField ("usn", PlayerPrefs.GetString("sessionUSN"));
		form.AddField ("g_name", "TapTheLetter");
		form.AddField ("level", "Hard");
		WWW www = new WWW (insertScoreUrl, form);

		yield return www;

	}

}
