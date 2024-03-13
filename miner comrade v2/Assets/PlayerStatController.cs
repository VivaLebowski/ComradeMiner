﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStatController : MonoBehaviour {

    public int hullStrength;
    public int credits;
    public int currentCargo;
    public GameObject moneyDisplay;
    private Text moneyDisplayText;
    

	// Use this for initialization
	void Start () {
        hullStrength = 100;
        credits = 0;
        currentCargo = 0;
        moneyDisplayText = moneyDisplay.GetComponent<Text>();


    }
	
	// Update is called once per frame
	void Update () {
        // this can be displayed via a call instead of every frame, it should change
        // rarely by comparison (TODO investigate menus for good places to call this)
         moneyDisplayText.text = credits.ToString() + "$";
	}
}
