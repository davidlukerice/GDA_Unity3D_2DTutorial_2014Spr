using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	/**
	 * Whether or not the game is stll running
	 * */
	public bool IsPlaying {get; private set;}

	/**
	 * A reference to the text to display when the game ends
	 * */
	public TextMesh gameOverText;

	// Use this for initialization
	void Start () {
		// start the game
		this.IsPlaying = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/**
	 * Ends the game
	 * */
	public void endGame() {
		// stop the game and show the gameOver text
		Debug.Log("Game Over!");
		this.IsPlaying = false;
		this.gameOverText.GetComponent<MeshRenderer>().enabled = true;
	}
}
