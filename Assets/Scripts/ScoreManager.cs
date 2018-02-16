using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{

	private int score;
	public Text highScoreText;
	public Text scoreText;

	public GameObject background;
	public Color[] colors;

	public AudioClip scoreSound;

	AudioSource playerAudioSource;

	void Update ()
	{

		HigScoreManager ();

		playerAudioSource = GetComponent<AudioSource> ();

	}


	void OnTriggerEnter2D (Collider2D coll)
	{

		if (coll.gameObject.tag == "Enemy") {

			playerAudioSource.PlayOneShot (scoreSound);
			score += 1;
			scoreText.text = "" + score;
			Destroy (coll.gameObject);

			if (score % 10 == 0) {

				//playerAudioSource.PlayOneShot (LevelUpSound);
				background.gameObject.GetComponent<SpriteRenderer> ().color = colors [Random.Range (0, colors.Length)];
				//background.gameObject.GetComponent<SpriteRenderer> ().color = Random.ColorHSV (0.0f, 0.5f, 0.0f, 0.5f, 0.0f, 0.5f);

			} 

		}


	}


	public void HigScoreManager ()
	{

		PlayerPrefs.SetInt ("Score", score);

		if (PlayerPrefs.GetInt ("Highscore") < score) {

			PlayerPrefs.SetInt ("Highscore", score);

		}

	}

}
