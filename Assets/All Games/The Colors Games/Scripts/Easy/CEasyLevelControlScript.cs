﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CEasyLevelControlScript : MonoBehaviour {

	private int score;
	public float time;
	private int num_question = 0;
	// Get references to game objects that should be disabled and enabled
	// at the start
	GameObject[] toEnable, toDisable;

	// References to game objects that should be enabled
	// when correct or incorrect answer is given
	public GameObject correctSign, incorrectSign, cup, trophySing, correctAnswer;

	// Variable to contain current scene build index
	int currentSceneIndex;

	// Variable name to pass to Player Prefs meaning which variable to set as got
	// Adjustable in inspector depending on current scene and trophy
	// you earn (if you do)
	public string whichCupGot = "Cup1Got";

	// Use this for initialization
	void Start () {
		num_question = PlayerPrefs.GetInt ("QuestionNum");
		score = PlayerPrefs.GetInt ("CEasyScore");

		// Getting current scene build index
		currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;

		// Finding game objects with tags "ToEnable" and "ToDisable"
		toEnable = GameObject.FindGameObjectsWithTag ("ToEnable");
		toDisable = GameObject.FindGameObjectsWithTag ("ToDisable");

		// Disabling game objects with tag "ToEnable"
		foreach (GameObject element in toEnable)
		{
			element.gameObject.SetActive (false);
		}

	}

	void Update ()
	{

		ScoreManager ();

	}

	// Method is invoked when correct answer is given
	public void RightAnswer()
	{

		score += 1;

		// Disabling game objects that are no longer needed
		foreach (GameObject element in toDisable)
		{
			element.gameObject.SetActive (false);
		}

		// Turn on "correct" sign
		correctSign.gameObject.SetActive (true);

		// Getting a value if you already got current trophy
		int Cupgot = PlayerPrefs.GetInt(whichCupGot);

		// If you already got current trophy
		if (Cupgot == 1)

			// then you proceed to next level
			Invoke ("LoadNextLevel", 1f);

		// if you don't have current trophy yet
		else
			// then GetTrophy method is invoked in 1 second
			Invoke ("GetTrophy", 1f);
	}

	// Method is invoked if incorrect answer is given
	public void WrongAnswer()
	{
		// Disabling game objects that are no longer needed
		foreach (GameObject element in toDisable)
		{
			element.gameObject.SetActive (false);
		}

		// Turn on "incorrect" sign
		incorrectSign.SetActive (true);
		correctAnswer.SetActive (true);

		// then you proceed to next level
		Invoke ("LoadNextLevel", 1f);

	}

	// Method is invoked if you don't have current trophy yet
	void GetTrophy()
	{
		// "Correct" sing is turned on
		correctSign.SetActive (false);

		// Trophy game object is shown
		cup.SetActive (true);

		// "You got new trophy" sign is shown
		trophySing.SetActive (true);

		// Set Player Prefs whichCupGot variable so you got this trophy
		// to store this value between the scenes
		PlayerPrefs.SetInt (whichCupGot, 1);

		// Invoke LoadNextLevel method in 1 second
		Invoke ("LoadNextLevel", 1f);
	}

	public void ScoreManager()
	{

		PlayerPrefs.SetInt ("CEasyScore", score);

	}

	// Method loads next level depending on current scenes build index
	void LoadNextLevel()
	{
		num_question = PlayerPrefs.GetInt("QuestionNum");
		num_question = num_question + 1;
		Debug.Log (num_question);
		PlayerPrefs.SetInt("QuestionNum", num_question);
		if (num_question != 20) {
			PlayerPrefs.GetInt ("QuestionNum", num_question);
			int index = randomize ();
			SceneManager.LoadScene (index);
		} else {
			SceneManager.LoadScene ("CEasy16");
		}
	}

	// Method loads MainMenu scene
	void GotoMainMenu()
	{
		SceneManager.LoadScene ("CEasyMainMenu");
	}

	int randomize() {
		int index = Random.Range (160, 174);
		return index;
	}

}