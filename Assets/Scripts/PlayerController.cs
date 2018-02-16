using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	public float moveSpeed;
	public float jumpForce;

	//public float increaseBigSize;
	//public float increaseSmallSize;

	public AudioClip jumpSound;

	AudioSource playerAS;


	private Rigidbody2D rb;


	void Start ()
	{

		rb = GetComponent<Rigidbody2D> ();

		playerAS = GetComponent<AudioSource> ();

	}


	void Update ()
	{

		if ((Input.GetButtonDown ("Jump") || Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.UpArrow))) {

			rb.velocity = new Vector2 (rb.velocity.x, jumpForce);

			playerAS.PlayOneShot (jumpSound);

		}
			
	}


	void OnCollisionEnter2D (Collision2D col)
	{

		// Initial Move Right
		if (col.gameObject.tag == "Initial Mover Right") {

			rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);

		}

		// Move Left
		if (col.gameObject.tag == "Right Wall") {

			rb.velocity = new Vector2 (-moveSpeed, rb.velocity.y);

		}

		// Move Right
		if (col.gameObject.tag == "Left Wall") {
			
			rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);

		}

		if (col.gameObject.tag == "Enemy") {

			SceneManager.LoadScene ("GameOver");

		}

		if (col.gameObject.tag == "Down Wall") {
			
			SceneManager.LoadScene ("GameOver");

		}

		if (col.gameObject.tag == "Up Wall") {

			SceneManager.LoadScene ("GameOver");

		}
			
	}


	/*void OnTriggerEnter2D (Collider2D col)
	{

		if (col.gameObject.tag == "MakeBig") {
			
			playerAS.PlayOneShot (makeBigSound);
			transform.localScale += new Vector3 (increaseBigSize, increaseBigSize, 1);
			Destroy (col.gameObject);

		}

		if (col.gameObject.tag == "MakeSmall") {

			playerAS.PlayOneShot (makeSmallSound);
			transform.localScale += new Vector3 (increaseSmallSize, increaseSmallSize, 1);
			Destroy (col.gameObject);

		}

	}*/


}
