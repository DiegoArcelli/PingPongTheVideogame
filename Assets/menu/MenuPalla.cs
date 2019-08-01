using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuPalla : MonoBehaviour {

	public float speed;

	void OnCollisionEnter2D(Collision2D coll){


		if (coll.gameObject.tag == "Cpu") {
			transform.Rotate (0f, 0f, -transform.rotation.eulerAngles.z);
			transform.Rotate (0f, 0f, Random.Range (-30, 30f));
		}

		if (coll.gameObject.tag == "Cpu2") {
			float z = 180 - transform.rotation.eulerAngles.z;
			transform.Rotate (0f, 0f, z);
			transform.Rotate (0f, 0f, Random.Range (-30, 30f));
		}


		if (coll.gameObject.tag == "Bordo") {
			float z = 360f - transform.rotation.eulerAngles.z;
			transform.Rotate (0f, 0f, z - transform.rotation.eulerAngles.z);
		}


		if (coll.gameObject.tag == "Punto1") {
			StartCoroutine(Punto());
		}


		if (coll.gameObject.tag == "Punto2") {
			StartCoroutine(Punto());
		}

	}



	IEnumerator Punto(){
		speed = 0f;
		transform.position = new Vector3 (0f, 0f, 0f);
		transform.Rotate (0f, 0f, -transform.rotation.eulerAngles.z);               
		yield return new WaitForSeconds(3);
		speed = 0.15f;

	}

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate (speed,0f,0f);



	}
}
