using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {

	public float speed = 1.0f;
	private bool playerPassed = true;

	private GameScript game;

	// Use this for initialization
	void Start () {
		this.game = Object.FindObjectOfType<GameScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.game.IsPlaying) return;

		this.transform.Translate(Vector3.left * this.speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) {
		var hero = other.gameObject.GetComponent<HeroScript>();
		if (hero && this.playerPassed) {
			hero.addPoint();
			this.playerPassed=false;
		}
	}
}
