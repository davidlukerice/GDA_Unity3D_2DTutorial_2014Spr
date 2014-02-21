using UnityEngine;
using System.Collections;

/**
 * A pair of obstacles(top and bottom) that the hero must pass in the middle
 * to get a point.
 * */
public class ObstacleScript : MonoBehaviour {

	/**
	 * How fast the obstacle moves to the left
	 * */
	public float speed = 1.0f;

	/**
	 * Whether or not the player has scored with this obstacle.
	 * */
	private bool playerPassed = true;

	/**
	 * Reference to the game state script
	 * */
	private GameScript game;

	// Use this for initialization
	void Start () {
		// Find the game script
		this.game = Object.FindObjectOfType<GameScript>();
	}
	
	// Update is called once per frame
	void Update () {
		// If the game is no longer playing, then don't update position
		if (!this.game.IsPlaying) return;

		// If the obstacle has gone off screen, then delete it.
		// This helps clear up resources so there aren't hundreds 
		// of obstacles off screen.
		if (this.transform.position.x <= -11.0f)
			Destroy(this.gameObject);

		// Move the obstacle to the left in proportion to the amount of time
		// that's passed since the last update
		this.transform.Translate(Vector3.left * this.speed * Time.deltaTime);
	}

	/*
	 * Called when a collider enters this object
	 * */
	void OnTriggerEnter2D(Collider2D other) {
		// if the other collider is a Hero, then give him/her a point
		var hero = other.gameObject.GetComponent<HeroScript>();
		if (hero && this.playerPassed) {
			hero.addPoint();
			this.playerPassed=false;
		}
	}
}
