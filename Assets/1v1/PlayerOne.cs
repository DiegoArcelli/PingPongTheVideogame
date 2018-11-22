using UnityEngine;
using System.Collections;

public class PlayerOne : MonoBehaviour {

	public float moveSpeed;	
	public int score;


	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void FixedUpdate () {



		if(Input.GetKey(KeyCode.W)){
			transform.Translate (0f,moveSpeed*Time.deltaTime,0f);
		}

		if(Input.GetKey(KeyCode.S)){
			transform.Translate (0f,-moveSpeed*Time.deltaTime,0f);
		}

	}
}
