using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

	public float timer;
	//public Text scoreText;

	void Start ()
	{

		PlayerPrefs.SetInt ("QuestionNum", 0);
		Debug.Log (PlayerPrefs.GetInt ("QuestionNum"));

	}


	public void LoadScene (string sceneName)
	{
		
		StartCoroutine (LoadSceneTimer (sceneName));

	}


	IEnumerator LoadSceneTimer (string sceneName)
	{

		yield return new WaitForSeconds (timer);
		SceneManager.LoadScene (sceneName);

	}


	public void Quit ()
	{

		Application.Quit ();

	}


}
