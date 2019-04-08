using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.script.GameInstance;
using Assets.script.Context;
using Assets.script.Card;

public class testcard : MonoBehaviour {
    ICard card;
    Iplayer player;
    IGameContext gamecontext;

	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("PLAYER").GetComponent<PlayerObject>().player;
        this.gamecontext = GameObject.Find("GameContext").GetComponent<gameContextObject>().GameContext;
        this.card = new red_die(player,gamecontext);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickCubeItem(UnityEngine.EventSystems.BaseEventData data = null) {
        this.card.play();
        Debug.Log (this.player.Score + "|" + this.card.player.Score);
    }
}
