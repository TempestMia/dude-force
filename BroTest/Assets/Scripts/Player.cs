using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public string name { get; set; }

	public float Speed;
	public Vector2 last_velocity;

	private bool isTouchingGround = false;

	[HideInInspector]
	public bool isJumping = false;

	public GameObject mainCharacter;

	private Transform mainCharacterTransform;

	// Use this for initialization
	void Start () {
		name = "Francii";
		mainCharacterTransform = mainCharacter.transform;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space) && !isJumping) {
			isJumping = true;
			Jump ();
		}

		if (isTouchingGround) {
			isJumping = false;
		}

		if(Input.GetKey(KeyCode.A)){
			//GetComponent<Rigidbody2D>().AddRelativeForce (new Vector2 (-20, 0));
			mainCharacterTransform.position = new Vector3(mainCharacterTransform.position.x - Speed, mainCharacterTransform.position.y, mainCharacterTransform.position.z);
		}	

		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().AddRelativeForce (new Vector2 (20, 0));
			mainCharacterTransform.Translate(new Vector3(Speed, 0, 0));
		}
	}

	private void Jump () {
		GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 300));
	}


	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log (collision.gameObject.name);
		if (collision.gameObject.name == "Ground01") {
			isTouchingGround = true;
		} else {
			isTouchingGround = false;
		}
	}

}
