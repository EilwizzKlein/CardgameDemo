using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.script.Context;


public class testClick : MonoBehaviour {
    GameObject go;
    IGameContext gameContext;
    // Use this for initialization
    void Start () {

       go = GameObject.Find("GameContext");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onClick() {
         gameContext = GameObject.Find("GameContext").GetComponent<gameContextObject>().GameContext;
        gameContext.CurrentGameState.NextState();
        Debug.Log(gameContext.CurrentGameState.StateName);
        // Debug.Log((go.GetComponent("Test1") ==  null).ToString());
    }
}
