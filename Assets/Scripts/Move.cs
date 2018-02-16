using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{

	public float moveSpeed;


	void Update ()
	{
		
		transform.Translate (0, -moveSpeed * Time.deltaTime, 0);

		if (transform.position.y <= -5.35f) {

			Destroy (gameObject);

		}
	 	
	}
}
