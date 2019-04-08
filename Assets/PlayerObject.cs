using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.script.Context;
using Assets.script.GameInstance;

public class PlayerObject : MonoBehaviour {
    public Iplayer player;

	// Use this for initialization
	void Start () {
        this.player = new Player();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
