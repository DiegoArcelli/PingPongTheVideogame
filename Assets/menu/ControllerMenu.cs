using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControllerMenu : MonoBehaviour {


	public int opz;
	public GameObject o1;
	public GameObject o2;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			opz+=1;
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			opz-=1;
		}

		if (opz < 0) {
			opz = 2;
		} else if(opz>2) {
			opz = 0;
		}

		if (opz == 0){
			GetComponent<SpriteRenderer> ().color = new Vector4 (255.0f, 0.0f, 0.0f, 255.0f);
		} else {
			GetComponent<SpriteRenderer> ().color = new Vector4 (255.0f, 255.0f, 255.0f, 255.0f);
		}

		if (opz == 0 && Input.GetKeyDown (KeyCode.Return)) {
			SceneManager.LoadScene("1vcpu");
		}

		if (opz == 1) {
			o1.GetComponent<SpriteRenderer> ().color = new Vector4 (255.0f, 0.0f, 0.0f, 255.0f);
		} else {
			o1.GetComponent<SpriteRenderer> ().color = new Vector4 (255.0f, 255.0f, 255.0f, 255.0f);
		}

		if (opz == 1 && Input.GetKeyDown (KeyCode.Return)) {
			SceneManager.LoadScene("2v2");
		}

		if (opz == 2) {
			o2.GetComponent<SpriteRenderer> ().color = new Vector4 (255.0f, 0.0f, 0.0f, 255.0f);
		} else {
			o2.GetComponent<SpriteRenderer> ().color = new Vector4 (255.0f, 255.0f, 255.0f, 255.0f);
		}

		if (opz == 2 && Input.GetKeyDown (KeyCode.Return)) {
			Application.Quit();
		}
	
	}
}
