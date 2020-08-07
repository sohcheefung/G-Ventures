using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastCheckPoint : MonoBehaviour
{
    //public LevelManager levelManager;
	public Sprite redBin;
	public Sprite greenBin;
	private SpriteRenderer checkpointSpriteRenderer;
	public bool winGame = false;
	public GameObject winGameScreen;
	public Text totalScore;
	public Text totalItem;
	public Text best_Score;
	
    // Start is called before the first frame update
    void Start()
    {
        //levelManager = FindObjectOfType<LevelManager>();
		checkpointSpriteRenderer = GetComponent<SpriteRenderer> ();
		winGameScreen.SetActive(false);
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
			{
				Debug.Log ("Last Checkpoint Reached " + transform.position);
				checkpointSpriteRenderer.sprite = greenBin;
				winGame = true;
				winGameScreen.SetActive(true);
				Time.timeScale = 0f;
				totalScore.text = PlayerPrefs.GetInt("TotalScore").ToString();
				totalItem.text = PlayerPrefs.GetInt("TotalItem").ToString();
				best_Score.text = PlayerPrefs.GetInt("TotalScore").ToString();
			}
	}
	
	public void checkBestScore()
	{
		
		
		//int bestScore = best_Score;
		//int currentScore = totalScore;
		
		int currentScore = PlayerPrefs.GetInt("TotalScore");
		int bestScore = PlayerPrefs.GetInt("TotalScore");
		
		if(bestScore > currentScore)
		{
			PlayerPrefs.SetString("TotalScore",best_Score.text);
		}
	}
	
	
	 
	
}
