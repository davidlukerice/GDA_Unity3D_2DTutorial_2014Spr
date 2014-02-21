using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public bool IsPlaying {get; private set;}
	public TextMesh gameOverText;

	// Use this for initialization
	void Start () {
		this.IsPlaying = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void endGame() {
		Debug.Log("Game Over!");
		this.IsPlaying = false;
		this.gameOverText.GetComponent<MeshRenderer>().enabled = true;
	}
}
