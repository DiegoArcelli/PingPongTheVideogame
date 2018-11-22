using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pallina : MonoBehaviour {

	public float speed;
	CpuAI score1;
	PlayerTwo score2;
	public Text score;

	void OnCollisionEnter2D(Collision2D coll){


		if (coll.gameObject.tag == "Cpu") {
			transform.Rotate (0f, 0f, -transform.rotation.eulerAngles.z);
			transform.Rotate (0f, 0f, Random.Range (-30, 30f));
		}

		if (coll.gameObject.tag == "Player2") {
			float z = 180 - transform.rotation.eulerAngles.z;
			transform.Rotate (0f, 0f, z);
			transform.Rotate (0f, 0f, Random.Range (-30, 30f));
		}


		if (coll.gameObject.tag == "Bordo") {
			float z = 360f - transform.rotation.eulerAngles.z;
			transform.Rotate (0f, 0f, z - transform.rotation.eulerAngles.z);
		}


		if (coll.gameObject.tag == "Punto1") {
			score1.score += 1;
			StartCoroutine(Punto());
		}


		if (coll.gameObject.tag == "Punto2") {
			score2.score += 1;
			StartCoroutine(Punto());
		}

	}



	IEnumerator Punto(){
		speed = 0f;
		transform.position = new Vector3 (0f, 0f, 0f);
		transform.Rotate (0f, 0f, -transform.rotation.eulerAngles.z);
		score.text = score1.score + "                                                      "  + score2.score;
		yield return new WaitForSeconds(3);
		score.text = "";
		speed = 0.4f;

	}

	// Use this for initialization
	void Start () {


		score1 = GameObject.FindGameObjectWithTag ("Cpu").GetComponent<CpuAI>();
		score2 = GameObject.FindGameObjectWithTag ("Player2").GetComponent<PlayerTwo>();
		score.text = "";

	}

	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate (speed,0f,0f);



	}
}
