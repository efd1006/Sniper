using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{


	public int xSpeed;
	public int ySpeed;
	public int zSpeed;


	void Update ()
	{


		transform.Rotate (xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);

		
	}


}
