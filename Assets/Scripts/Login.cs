using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {
	
	public InputField usn;
	public InputField password;
	string loginUrl = "https://apisniper.000webhostapp.com/API/login.php";
	string sessionUSN;
	public Text msg;

	public void getLogin()
	{
		if (usn.text != "" || password.text != "") {
			msg.text = "";
			Debug.Log(usn.text);
			Debug.Log(password.text);
			StartCoroutine(loginToDB(usn.text, password.text));
		} else {
			msg.text =  "Incorrect Details";
		}
	}

	IEnumerator loginToDB(string student_number, string password)
	{
		msg.text = "Please Wait...";
		WWWForm form = new WWWForm();
		form.AddField ("usnPost", student_number);
		form.AddField ("passwordPost", password);
		WWW www = new WWW (loginUrl, form);

		yield return www;
		Debug.Log (www.text);
		if (www.text == "success") {
			msg.color = Color.green;
			msg.text = "Login Success";
			sessionUSN = student_number;
			PlayerPrefs.SetString ("sessionUSN", sessionUSN);
			Invoke ("GotoMainMenu", 1f);
		} else {
			msg.text = "User Not Found";
		}
	}
		
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GotoMainMenu()
	{
		SceneManager.LoadScene ("GameMenu1");
	}
}