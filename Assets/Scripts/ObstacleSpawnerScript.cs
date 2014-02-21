using UnityEngine;
using System.Collections;

public class ObstacleSpawnerScript : MonoBehaviour {

	public GameObject[] obstacles;
	public float spawnDelta = 3.0f;
	private float timeUntilSpawn = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.timeUntilSpawn-=Time.deltaTime;

		if (this.timeUntilSpawn <= 0.0f) {
			this.timeUntilSpawn = this.spawnDelta;
			SpawnNewObstacle();
		}
	}

	private void SpawnNewObstacle() {
		var index = Mathf.FloorToInt(Random.value*obstacles.Length);
		var obstacle = (GameObject)Instantiate(obstacles[index]);
		obstacle.transform.Translate(Vector3.right * 11.0f);
		obstacle.transform.parent = this.transform;
	}
}
