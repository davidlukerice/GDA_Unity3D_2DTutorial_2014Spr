using UnityEngine;
using System.Collections;

public class ObstacleSpawnerScript : MonoBehaviour {

	/**
	 * All the possible obstacles this spawner can make
	 * */
	public GameObject[] obstacles;

	/**
	 * The time (in seconds) between spawning obstacles
	 * */
	public float spawnDelta = 3.0f;

	/**
	 * How far right a new obstacle will spawn
	 * */
	public float spawnLocation = 11.0f;

	/**
	 * The time left until the next spawn
	 * */
	private float timeUntilSpawn = 0.0f;

	/**
	 * A reference to the global game state script
	 * */
	private GameScript game;

	// Use this for initialization
	void Start () {
		// Find the game script
		this.game = Object.FindObjectOfType<GameScript>();
	}
	
	// Update is called once per frame
	void Update () {
		// If the game is no longer running (aka, the player died)
		// stop spawning things
		if (!this.game.IsPlaying) return;

		// Lower the time left by the time passed
		this.timeUntilSpawn-=Time.deltaTime;

		// If the timer ran out, spawn a new obstacle
		// and reset the timer
		if (this.timeUntilSpawn <= 0.0f) {
			this.timeUntilSpawn = this.spawnDelta;
			SpawnNewObstacle();
		}
	}

	/**
	 * Spawns a new obstacle
	 * */
	private void SpawnNewObstacle() {
		// get a random index for which type of obstacle to spawn
		var index = Mathf.FloorToInt(Random.value*obstacles.Length);

		// get that prefab and spawn a new one
		var obstacle = (GameObject)Instantiate(obstacles[index]);

		// Move the obstacle to its starting position
		obstacle.transform.Translate(Vector3.right * this.spawnLocation);

		// Add it as a child to the parent
		obstacle.transform.parent = this.transform;
	}
}
