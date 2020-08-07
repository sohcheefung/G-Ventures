using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	Text text;
	public static int scoreAmount;
	
	void Start()
	{
		scoreAmount = 0;
		text = GetComponent<Text> ();
		//scoreAmount = PlayerPrefs.GetInt("TotalScore");
		text.text = scoreAmount.ToString();
	}
	
	void Update () 
	{
		PlayerPrefs.SetInt("TotalScore", scoreAmount);
		text.text = "Score:" + scoreAmount.ToString();
	}
}
