using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {

	public int score = 0;
	public float jumpForce = 100.0f;
	public TextMesh scoreText;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Check if the Space bar was pressed
		if (Input.GetKeyDown("space")) {
			var rigidBody = this.GetComponent<Rigidbody2D>();
			rigidBody.AddForce(Vector2.up * this.jumpForce);
		}
	}
	
	public void addPoint() {
		this.score++;
		this.scoreText.text = ""+this.score;
	}
}
