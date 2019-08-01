using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Palla : MonoBehaviour {

	public float speed;
	PlayerOne score1;
	PlayerTwo score2;
	public AudioSource source;
	public GameObject loseText;
	public GameObject winText;
	public AudioClip ost;
	public Text menu;
	public Text score;
	int pause;

	void OnCollisionEnter2D(Collision2D coll){


		if (coll.gameObject.tag == "Player1") {
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


		score1 = GameObject.FindGameObjectWithTag ("Player1").GetComponent<PlayerOne>();
		score2 = GameObject.FindGameObjectWithTag ("Player2").GetComponent<PlayerTwo>();
		score.text = "";
		menu.text = "";
		pause = 0;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate (speed,0f,0f);


	}

	void Update(){

		if(score1.score == 10){
			loseText.GetComponent<SpriteRenderer> ().enabled = true;
			menu.text = "Press Enter to restart the match\nPress E button to go to the menu";
			Time.timeScale = 0.0f;
			if (Input.GetKey (KeyCode.Return)) {
				Time.timeScale = 1.0f;
				SceneManager.LoadScene("2v2");
			} else if (Input.GetKey (KeyCode.Escape)) {
				Time.timeScale = 1.0f;
				SceneManager.LoadScene("menu");
			}
		}

		if(score2.score == 10){
			winText.GetComponent<SpriteRenderer> ().enabled = true;
			menu.text = "Press Enter to restart the match\nPress E button to go to the menu";
			Time.timeScale = 0.0f;
			if (Input.GetKey (KeyCode.Return)) {
				Time.timeScale = 1.0f;
				SceneManager.LoadScene("2v2");
			} else if (Input.GetKey (KeyCode.Escape)) {
				Time.timeScale = 1.0f;
				SceneManager.LoadScene("menu");
			}
		}

		if (Time.timeScale == 1.0f && Input.GetKeyDown (KeyCode.P)) {
			menu.text = "Press Enter to restart the match\nPress E button to go to the menu";
			Time.timeScale = 0.0f;
		} else if (Time.timeScale == 0.0f && Input.GetKeyDown (KeyCode.E)) {
			menu.text = "";
			Time.timeScale = 1.0f;
			SceneManager.LoadScene("menu");
		} else if(Time.timeScale == 0.0f && Input.GetKeyDown (KeyCode.Return)){
			menu.text = "";
			Time.timeScale = 1.0f;
		}

	}
}
