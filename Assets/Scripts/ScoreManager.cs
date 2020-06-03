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
	}
	
	void Update () 
	{
		text.text = "Score:" + scoreAmount.ToString();
	}
}
