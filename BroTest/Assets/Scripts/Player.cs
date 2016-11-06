using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public string name { get; set; }

	public Vector2 last_velocity;

	// Use this for initialization
	void Start () {
		name = "Francii";
		last_velocity = GetComponent<Rigidbody2D> ().velocity;
		GetComponent<BoxCollider2D>().
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){
			GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (0, 300));
		}

		if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().AddRelativeForce (new Vector2 (-20, 0));
		}	

		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().AddRelativeForce (new Vector2 (20, 0));
		}
	}
}
