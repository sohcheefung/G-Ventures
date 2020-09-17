using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager4 : MonoBehaviour
{
	Text text;
	public Text highscoreText;
	
	public static int scoreAmount;
	public static int highScore;
	
	public GameObject minimumScore;
	
	void Start()
	{
		scoreAmount = 0;
		text = GetComponent<Text> ();
		text.text = scoreAmount.ToString();
		highScore = PlayerPrefs.GetInt("HighScore4",0);
		minimumScore.SetActive(false);
		
	}
	
	void Update () 
	{
		PlayerPrefs.SetInt("TotalScore4", scoreAmount);
		text.text = "Score:" + scoreAmount.ToString();
	
		if (scoreAmount > highScore)
		{
			highScore = scoreAmount;
			PlayerPrefs.SetInt("HighScore4",highScore);
			highscoreText.text = " " + highScore;
		}
	}
		
		
		IEnumerator ShowAndHide()
		{
			minimumScore.SetActive(true);
			yield return new WaitForSeconds(1f);
			minimumScore.SetActive(false);
		}
		
		public void showText(){
		
		StartCoroutine(ShowAndHide());
		}
}