﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHardBackButtonScript : MonoBehaviour {

	// Load Main Menu scene when Back Button is pressed
	public void BackToMainMenu()
	{
		PlayerPrefs.SetInt ("QuestionNum", 0);
		SceneManager.LoadScene ("CHardMainMenu");
	}
}
