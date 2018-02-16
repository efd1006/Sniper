﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MediumTimer : MonoBehaviour
{

	public MediumLevelControlScript MediumlevelControlScript;

	public Image timer;
	/*
	public Button correct;
	public Button wrong;
	public Button wrong2;
	public Button wrong3;
	*/

	void Start ()
	{
		
		MediumlevelControlScript = FindObjectOfType (typeof(MediumLevelControlScript)) as MediumLevelControlScript;
		StartCoroutine ("GameTimer");

	}


	void Update ()
	{



	}
		
	IEnumerator GameTimer()
	{

		timer = GetComponent<Image>();
		timer.fillAmount = 1;
		float timeToWait = 3f;
		float incrementToRemove = 0.1f;
		float x = timer.fillAmount/timeToWait * incrementToRemove;

		while (timeToWait>0) {
			yield return new WaitForSeconds (incrementToRemove);

			timer.fillAmount-=x;
			timeToWait-=incrementToRemove; 

		}

		MediumlevelControlScript.WrongAnswer();


		/*
		if (timer.fillAmount <= 0.1f) {
			correct.GetComponent<Button> ().image.color = Color.yellow;
			wrong .GetComponent<Button> ().image.color = Color.red;
			wrong2.GetComponent<Button> ().image.color = Color.red;
			wrong3.GetComponent<Button> ().image.color = Color.red;
		}*/

	}


}