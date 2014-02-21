using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {

	/**
	 * The number of pipes the hero has passed
	 * */
	public int score = 0;

	/**
	 * How much upward force should be applied to the hero on jump
	 * */
	public float jumpForce = 100.0f;

	/**
	 * A reference to the text to show the score on
	 * */
	public TextMesh scoreText;

	/**
	 * a reference to the game state script
	 * */
	private GameScript game;

	// Use this for initialization
	void Start () {
		// get the game script
		this.game = Object.FindObjectOfType<GameScript>();
	}
	
	// Update is called once per frame
	void Update () {

		// if the game is over, dont let the player jump
		if (!this.game.IsPlaying) return;

		// Check if the Space bar was pressed
		if (Input.GetKeyDown("space")) {
			// apply an upward force to 'jump'
			var rigidBody = this.GetComponent<Rigidbody2D>();
			rigidBody.AddForce(Vector2.up * this.jumpForce);
		}
	}

	/**
	 * Increases the player's score by 1 and updates the scoreText
	 * */
	public void addPoint() {
		this.score++;
		this.scoreText.text = ""+this.score;
	}
}
