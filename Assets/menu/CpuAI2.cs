using UnityEngine;
using System.Collections;

public class CpuAI2 : MonoBehaviour {

	public float moveSpeed;	
	public int score;
	Pallina palla;
	CpuAI3 cpu;
	private Transform target;
	public int lastHit; 


	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "Palla") {
			lastHit = 0;
			cpu.lastHit = 1;
		}	

	}


	// Use this for initialization
	void Start () {

		palla = GameObject.FindGameObjectWithTag ("Palla").GetComponent<Pallina>();
		target = GameObject.FindGameObjectWithTag ("Palla").GetComponent <Transform>();
		cpu = GameObject.FindGameObjectWithTag ("Cpu").GetComponent<CpuAI3>();
		moveSpeed = 6.0f;
		lastHit = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {

		transform.position = Vector2.MoveTowards (new Vector3(7.89f,transform.position.y,transform.position.z), new Vector3(7.89f,target.position.y,target.position.z), moveSpeed*Time.deltaTime);
		if (lastHit == 0) {
			moveSpeed = 3.0f;
		} else if (lastHit == 1) {
			moveSpeed = 6.0f;
		}


	}
}
