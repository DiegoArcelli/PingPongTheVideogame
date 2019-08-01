using UnityEngine;
using System.Collections;

public class PlayerTwo : MonoBehaviour {

	public float moveSpeed;	
	public int score;
	private BoxCollider2D box;


	void OnCollisionEnter2D(Collision2D coll){

		Collider2D collider = coll.collider;
		Vector3 contactPoint = coll.contacts[0].point;
		Vector3 center = collider.bounds.center;

	}


	// Use this for initialization
	void Start () {

		box = GetComponent<BoxCollider2D> ();

	}

	// Update is called once per frame
	void FixedUpdate () {



		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate (0f,moveSpeed*Time.deltaTime,0f);
		}

		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate (0f,-moveSpeed*Time.deltaTime,0f);
		}

	}
}
