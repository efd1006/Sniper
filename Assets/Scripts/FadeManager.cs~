using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{

	public static FadeManager Instance { set; get; }

	public Image fadeImage;
	public Color fadeColorStart;
	public Color fadeColorEnd;
	public float fadeInTime;
	public float fadeOutTime;
	private float transition;
	private float duration;
	private bool isShowing;
	private bool isInTransition;


	private void Awake ()
	{

		Instance = this;
		Fade (false, fadeInTime);

	}


	public void Fade (bool showing, float duration)
	{

		isShowing = showing;
		isInTransition = true;
		this.duration = duration;
		transition = (isShowing) ? 0 : 1;

	}


	private void Update ()
	{

		if (!isInTransition) {
			
			return;

		}

		transition += (isShowing) ? Time.deltaTime * (1 / duration) : -Time.deltaTime * (1 / duration);
		fadeImage.color = Color.Lerp (fadeColorStart, fadeColorEnd, transition);

		if (transition > 1 || transition < 0) {
			
			isInTransition = false;

		}

	}


	public void GetFade ()
	{

		Fade (true, fadeOutTime);

	}

}
