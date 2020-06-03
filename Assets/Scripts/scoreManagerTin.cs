using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManagerTin : MonoBehaviour
{
	public static bool ScoringScreenAppear = false;
    public GameObject scoringscreenUI;
	public GameObject buttonLeft;
	public GameObject buttonRight;
	public GameObject buttonJump;
	
	private Timer time;
	private PlayerMovement player;
   
   //[SerializeField] private Image TinImage;
   
	void Start(){
		time = GameObject.FindGameObjectWithTag("timer").GetComponent<Timer>();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
		
	}
   
	public void score_Tin()
	{
		scoringscreenUI.SetActive(false);
		ScoringScreenAppear = false;
		Debug.Log("collect tin");
		ItemManager.itemAmount += 1;
		ScoreManager.scoreAmount +=100;
		player.displayPointsGood();
		buttonLeft.SetActive(true);
		buttonRight.SetActive(true);
		buttonJump.SetActive(true);
		time.Stop();
	}
	
	public void wrong_Bin1()
	{
		scoringscreenUI.SetActive(false);
		ScoringScreenAppear = false;
		ItemManager.itemAmount += 1;
		if(ScoreManager.scoreAmount > 0)
		{
			ScoreManager.scoreAmount -=10;
		}
		player.displayPointsBad();
		buttonLeft.SetActive(true);
		buttonRight.SetActive(true);
		buttonJump.SetActive(true);
		Debug.Log("Wrong");
		time.Stop();
	}
	
	public void wrong_Bin2()
	{
		scoringscreenUI.SetActive(false);
		ScoringScreenAppear = false;
		ItemManager.itemAmount += 1;
		if(ScoreManager.scoreAmount > 0)
		{
			ScoreManager.scoreAmount -=10;
		}
		player.displayPointsBad();
		buttonLeft.SetActive(true);
		buttonRight.SetActive(true);
		buttonJump.SetActive(true);
		Debug.Log("Wrong");
		time.Stop();
	}
	
	public void pausetoscore()
		{
		scoringscreenUI.SetActive(true);
		ScoringScreenAppear = true;
		buttonLeft.SetActive(false);
		buttonRight.SetActive(false);
		buttonJump.SetActive(false);
		time.Began();
		}
		
}
