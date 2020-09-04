using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager5 : MonoBehaviour
{
    Text text;
	public Text highscoreText;
	
	public static int scoreAmount;
	public static int highScore;
	
	public GameObject buttonSucceed;
	public GameObject buttonFailed;
	
	public GameObject minimumScore;
	
	void Start()
	{
		scoreAmount = 0;
		text = GetComponent<Text> ();
		text.text = scoreAmount.ToString();
		highScore = PlayerPrefs.GetInt("HighScore5",0);
		minimumScore.SetActive(false);
		
	}
	
	void Update () 
	{
		PlayerPrefs.SetInt("TotalScore5", scoreAmount);
		text.text = "Score:" + scoreAmount.ToString();
	
		if (scoreAmount > highScore)
		{
			highScore = scoreAmount;
			PlayerPrefs.SetInt("HighScore5",highScore);
			highscoreText.text = " " + highScore;
		}
		if(scoreAmount < 700)
				{
					buttonSucceed.SetActive(false);
					buttonFailed.SetActive(true);
				}else
				{
					buttonSucceed.SetActive(true);
					buttonFailed.SetActive(false);
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
