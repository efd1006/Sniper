using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour
{
	
	public Transform destinationPoint;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;


	void Start ()
	{
		
		startTime = Time.time;

		journeyLength = Vector3.Distance (transform.position, destinationPoint.position);

	}


	void Update ()
	{
		
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp (transform.position, destinationPoint.position, fracJourney);

	}

}