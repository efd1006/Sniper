using UnityEngine;
using System.Collections;

public class EnemySpawner1 : MonoBehaviour
{

	public float speed;

	public GameObject[] objs;

	void Start ()
	{

		InvokeRepeating ("Generate", 0, speed);

	}


	void Generate ()
	{

		float x = Random.Range (-0.85f, 0.85f);
		float y = Random.Range (5.25f, 7.0f);

		Vector3 Target = new Vector3 (x, y, 1);
		Target.z = 1;

		Instantiate (objs [Random.Range (0, 9)], Target, Quaternion.identity);

	}


}
