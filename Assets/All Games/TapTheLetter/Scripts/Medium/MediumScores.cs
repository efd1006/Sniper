using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MediumScores : MonoBehaviour
{


	public Text game1Score;
	public Text game2Score;
	public Text game3Score;
	public Text game4Score;
	public Text game5Score;
	 


	void Start ()
	{


		game1Score.text = "" + PlayerPrefs.GetInt ("Score");

		
	}


	public void MainMenu ()
	{


		SceneManager.LoadScene ("MediumMainMenu");


	}


}
