using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastCheckPoint2 : MonoBehaviour
{
   
	public Sprite redBin;
	public Sprite greenBin;
	private SpriteRenderer checkpointSpriteRenderer;
	public bool winGame = false;
	public GameObject winGameScreen;
	
	public Text totalScore;
	public Text totalItem;
	public Text highScore;
	
	public GameObject buttonSucceed;
	public GameObject buttonFailed;
	int levelPassed;
	
	public AudioSource winSound;
	
    // Start is called before the first frame update
    void Start()
    {
		checkpointSpriteRenderer = GetComponent<SpriteRenderer> ();
		winGameScreen.SetActive(false);
		levelPassed = PlayerPrefs.GetInt("LevelPassed");
		winSound = GetComponent<AudioSource> ();
		
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
				totalScore.text = PlayerPrefs.GetInt("TotalScore2").ToString();
				totalItem.text = PlayerPrefs.GetInt("TotalItem1").ToString();
				highScore.text = PlayerPrefs.GetInt("HighScore2").ToString();
				winSound.Play();
				if(ScoreManager2.scoreAmount < 300)
					{
					buttonSucceed.SetActive(false);
					buttonFailed.SetActive(true);
					}else
					{
					buttonSucceed.SetActive(true);
					buttonFailed.SetActive(false);
					PlayerPrefs.SetInt("LevelPassed",2);
					}
				
			}
	}
}