﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AHardBackButtonScript : MonoBehaviour {

	// Load Main Menu scene when Back Button is pressed
	public void BackToMainMenu()
	{
		SceneManager.LoadScene ("AHardMainMenu");
	}
}
