using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{

	private GameObject[] characterList;

	private int Character;

	//private Button btn;
	//private int lvl;


	private void Start ()
	{

		/*lvl = PlayerPrefs.GetInt ("Best level");

		btn = GameObject.Find ("Image_Button_Ball0").GetComponent<Button> ();

		if (lvl >= 10) {

			btn.enabled = false;

		}*/


		Character = PlayerPrefs.GetInt ("CharacterSelected");

		characterList = new GameObject[transform.childCount];

		// Fill the array with characters
		for (int i = 0; i < transform.childCount; i++) {

			characterList [i] = transform.GetChild (i).gameObject;

		}

		// Toggle off their renderer
		foreach (GameObject go in characterList) {

			go.SetActive (false);

		}

		// Toggle on the selected character
		if (characterList [Character]) {

			characterList [Character].SetActive (true);

		}

	}

		
	public void Ball0 ()
	{

		Character = 0;

		characterList [Character].SetActive (true);

		Confirm ();

	}


	public void Ball1 ()
	{

		Character = 1;

		characterList [Character].SetActive (true);

		Confirm ();

	}


	public void Ball2 ()
	{

		Character = 2;
	
		characterList [Character].SetActive (true);

		Confirm ();

	}


	public void Confirm ()
	{

		PlayerPrefs.SetInt ("CharacterSelected", Character);
		SceneManager.LoadScene ("GameMenu");
	
	}


}
