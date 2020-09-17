﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{
	
	public Button level02Button, level03Button, level04Button, level05Button;
	int levelPassed;
	
    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
		level02Button.interactable = false;
		level03Button.interactable = false;
		level04Button.interactable = false;
		level05Button.interactable = false;
		
		switch (levelPassed) {
		case 1:
			level02Button.interactable = true;
			break;
		case 2:
			level02Button.interactable = true;
			level03Button.interactable = true;
			break;
		case 3:
			level02Button.interactable = true;
			level03Button.interactable = true;
			level04Button.interactable = true;
			break;
		case 4:
			level02Button.interactable = true;
			level03Button.interactable = true;
			level04Button.interactable = true;
			level05Button.interactable = true;
			break;
		}
    }
	

   public void resetPlayerPref()
   {
	level02Button.interactable = false;
	level03Button.interactable = false;
	level04Button.interactable = false;
	level05Button.interactable = false;
	PlayerPrefs.DeleteAll();
   }
}
