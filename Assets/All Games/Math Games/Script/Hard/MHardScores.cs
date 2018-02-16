using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MHardScores : MonoBehaviour
{


	public Text game1Score;
	public Text game2Score;
	public Text game3Score;
	public Text game4Score;
	public Text game5Score;
	public Text game6Score;
	public Text game7Score;
	public Text game8Score;
	public Text game9Score;
	public Text game10Score;
	 


	void Start ()
	{


		game1Score.text = "" + PlayerPrefs.GetInt ("Score");

		
	}


	public void MainMenu ()
	{


		SceneManager.LoadScene ("MHardMainMenu");


	}


}
