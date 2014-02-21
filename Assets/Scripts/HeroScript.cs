using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {

	public int score = 0;
	public float jumpForce = 100.0f;
	public float maxUpForce = 100.0f;
	public TextMesh scoreText;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			Debug.Log("Jump!");

			var rigidBody = this.GetComponent<Rigidbody2D>();
			rigidBody.AddForce(Vector2.up * this.jumpForce);
			//rigidBody.
		}
	}
	
	public void addPoint() {
		this.score++;
		this.scoreText.text = ""+this.score;
	}
}
