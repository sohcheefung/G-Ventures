﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastCheckPoint4 : MonoBehaviour
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
	public Transform winBurst;
	int levelPassed;
	
	public AudioSource winSound;
	
    // Start is called before the first frame update
    void Start()
    {
		checkpointSpriteRenderer = GetComponent<SpriteRenderer> ();
		winGameScreen.SetActive(false);
		levelPassed = PlayerPrefs.GetInt("LevelPassed");
		winSound = GetComponent<AudioSource> ();
		winBurst.GetComponent<ParticleSystem> ().enableEmission = false;
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
			{
				Debug.Log ("Last Checkpoint Reached " + transform.position);
				checkpointSpriteRenderer.sprite = greenBin;
				winGame = true;
				winGameScreen.SetActive(true);
				winBurst.GetComponent<ParticleSystem> ().enableEmission = true;
				Time.timeScale = 1f;
				totalScore.text = PlayerPrefs.GetInt("TotalScore4").ToString();
				totalItem.text = PlayerPrefs.GetInt("TotalItem2").ToString();
				highScore.text = PlayerPrefs.GetInt("HighScore4").ToString();
				winSound.Play(); 
				if(ScoreManager4.scoreAmount < 500)
					{
					buttonSucceed.SetActive(false);
					buttonFailed.SetActive(true);
					}else
					{
					buttonSucceed.SetActive(true);
					buttonFailed.SetActive(false);
					PlayerPrefs.SetInt("LevelPassed",4);
					}
			
				
			}
	}
	}