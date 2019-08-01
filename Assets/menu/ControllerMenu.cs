using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerMenu : MonoBehaviour {


	public int opz;
	public GameObject o1;
	public GameObject o2;
	public Text rules;
	public bool ruleShow;


	// Use this for initialization
	void Start () {
			
		Time.timeScale = 1.0f;
		rules.GetComponent<Text>().enabled = false;
		ruleShow = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (opz == 2 && Input.GetKeyDown (KeyCode.Return)) {
			o2.GetComponent<SpriteRenderer> ().enabled = false;
			o1.GetComponent<SpriteRenderer> ().enabled = false;
			this.GetComponent<SpriteRenderer> ().enabled = false;
			rules.GetComponent<Text> ().enabled = true;
			ruleShow = true;
		}


		if (Input.GetKeyDown (KeyCode.DownArrow) && ruleShow==false) {
			opz+=1;
		}

		if (Input.GetKeyDown (KeyCode.UpArrow) && ruleShow==false) {
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
			if (ruleShow == false) {
				o2.GetComponent<SpriteRenderer> ().enabled = false;
				o1.GetComponent<SpriteRenderer> ().enabled = false;
				this.GetComponent<SpriteRenderer> ().enabled = false;
				rules.GetComponent<Text> ().enabled = true;
				ruleShow = true;
			} 
		}

		if (Input.GetKeyDown (KeyCode.E) && ruleShow==true) {
			o2.GetComponent<SpriteRenderer> ().enabled = true;
			o1.GetComponent<SpriteRenderer> ().enabled = true;
			this.GetComponent<SpriteRenderer> ().enabled = true;
			rules.GetComponent<Text> ().enabled = false;
			ruleShow = false;
		}

	
	}
		
}
