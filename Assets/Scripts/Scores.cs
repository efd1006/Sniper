using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{


	public Text easy1Score;
	public Text easy2Score;
	public Text easy3Score;
	public Text easy4Score;
	public Text easy5Score;

	public Text medium1Score;
	public Text medium2Score;
	public Text medium3Score;
	public Text medium4Score;
	public Text medium5Score;
	 
	public Text hard1Score;
	public Text hard2Score;
	public Text hard3Score;
	public Text hard4Score;
	public Text hard5Score;

	void Start ()
	{

		easy1Score.text = "" + PlayerPrefs.GetInt ("EasyScore");
		medium1Score.text = "" + PlayerPrefs.GetInt ("MediumScore");
		hard1Score.text = "" + PlayerPrefs.GetInt ("HardScore");

		easy2Score.text = "" + PlayerPrefs.GetInt ("SEasyScore");
		medium2Score.text = "" + PlayerPrefs.GetInt ("SMediumScore");
		hard2Score.text = "" + PlayerPrefs.GetInt ("SHardScore");

		easy3Score.text = "" + PlayerPrefs.GetInt ("MEasyScore");
		medium3Score.text = "" + PlayerPrefs.GetInt ("MHardScore");
		hard3Score.text = "" + PlayerPrefs.GetInt ("MMediumScore");

		easy4Score.text = "" + PlayerPrefs.GetInt ("CEasyScore");
		medium4Score.text = "" + PlayerPrefs.GetInt ("CMediumScore");
		hard4Score.text = "" + PlayerPrefs.GetInt ("CHardScore");

		easy5Score.text = "" + PlayerPrefs.GetInt ("AEasyScore");
		medium5Score.text = "" + PlayerPrefs.GetInt ("AMediumScore");
		hard5Score.text = "" + PlayerPrefs.GetInt ("AHardScore");
	}


	public void MainMenu ()
	{


		SceneManager.LoadScene ("MainMenu");


	}


}
