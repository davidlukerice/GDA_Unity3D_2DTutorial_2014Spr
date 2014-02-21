using UnityEngine;
using System.Collections;

public class HalfObstacleScript : MonoBehaviour {
	private GameScript game;

	// Use this for initialization
	void Start () {
		this.game = Object.FindObjectOfType<GameScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("onTriggerEnter");
	}
	void OnCollisionEnter2D (Collision2D other) {
		this.game.endGame();
	}
}
