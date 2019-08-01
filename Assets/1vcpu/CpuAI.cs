using UnityEngine;
using System.Collections;

public class CpuAI : MonoBehaviour {

	public float moveSpeed;	
	public int score;
	Pallina palla;
	private Transform target;

	// Use this for initialization
	void Start () {
	
		palla = GameObject.FindGameObjectWithTag ("Palla").GetComponent<Pallina>();
		target = GameObject.FindGameObjectWithTag ("Palla").GetComponent <Transform>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.position = Vector2.MoveTowards (new Vector3(-7.89f,transform.position.y,transform.position.z), new Vector3(-7.89f,target.position.y,target.position.z), moveSpeed*Time.deltaTime);


	}

}

