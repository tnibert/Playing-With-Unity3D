using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour {

	Player player;

	// Use this for initialization
	void Start () {
		//GameObject playerObj = GameObject.Find("Player");
		//player = playerObj.GetComponent<Player>();
		player = FindObjectOfType<Player>();
		player.onPlayerDeath += GameOver;     // subscribe GameOver function to onPlayerDeath event
		player.onCoinGrab += DrawCoinCount;     // subscribe to onCoinGrab, we won't need this when we actually add a UI
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DrawCoinCount()
	{
		print(player.coinCount);
	}

	public void GameOver()
	{
		print("The player has died");
	}
}
