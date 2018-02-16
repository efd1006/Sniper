using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MediumWinSceneScript : MonoBehaviour {

	public Text scoreText;
	private int score;
	string insertScoreUrl = "https://apisniper.000webhostapp.com/API/insertscore.php";

	// Use this for initialization
	void Start () {

		scoreText.text = "Score: " + PlayerPrefs.GetInt ("MediumScore");
		StartCoroutine (insertToDB(PlayerPrefs.GetInt ("MediumScore")));
		// Invoke GotoMainMenu method in 1 second
		Invoke ("GotoMainMenu", 1f);
	}

	// Load MainMenu scene
	void GotoMainMenu()
	{
		PlayerPrefs.SetInt ("QuestionNum", 0);
		SceneManager.LoadScene ("MainMenuMedium");
	}
	IEnumerator insertToDB(int score)
	{
		WWWForm form = new WWWForm();
		form.AddField ("score", score);
		form.AddField ("usn", PlayerPrefs.GetString("sessionUSN"));
		form.AddField ("g_name", "TapTheLetter");
		form.AddField ("level", "Medium");
		WWW www = new WWW (insertScoreUrl, form);

		yield return www;

	}

}
