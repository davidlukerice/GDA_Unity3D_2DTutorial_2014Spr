using UnityEngine;
using System.Collections;

/**
 * Either the top or bottom of a full obstacle.
 * */
public class HalfObstacleScript : MonoBehaviour {

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
	}

	void OnCollisionEnter2D (Collision2D other) {
		// If anything hits this obstacle, it's most likely the player
		// so end the game.
		this.game.endGame();
	}
}
