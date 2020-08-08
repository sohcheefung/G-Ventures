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
	public Text highScore;
	//public GameObject buttonSucceed;
	//public GameObject buttonFailed;
	
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
				highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
				/*int highscore = PlayerPrefs.GetInt("highscore",0);
				int currentscore = ScoreManager.scoreAmount;
				
				if(currentscore > highscore)
				{
					//currentscore = highscore;
					PlayerPrefs.SetString("highscore",highScore.text);
					//highScore.text = "High Score: " + highscore;
				}
	
				
				if(currentscore < 100)
				{
					buttonSucceed.SetActive(false);
					buttonFailed.SetActive(true);
				}else
				{
					buttonSucceed.SetActive(true);
					buttonFailed.SetActive(false);
				}*/
			}
	}
	
	
		
		
		
		
	
	
	
	
	
	
	
	 
	
}
