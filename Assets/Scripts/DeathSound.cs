using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSound : MonoBehaviour
{

	public AudioClip deathSound;

	AudioSource audioSources;


	void Start ()
	{

		audioSources = GetComponent<AudioSource> ();

	}


	void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.tag == "Player") {

			audioSources.PlayOneShot (deathSound);

		}

	}


}
