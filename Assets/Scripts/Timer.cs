using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Image timerBar;
	public float maxTime = 5f;
	public bool timerIsRunning = false;
	float timeLeft;
	public GameObject timesUpText;
	
	public GameObject scoreScreenTin;
	public GameObject scoreScreenPaper;
	public GameObject scoreScreenGlass;
	
	public GameObject buttonLeft;
	public GameObject buttonRight;
	public GameObject buttonJump;
	
    // Start is called before the first frame update
	
	void Start (){
		timerBar = GetComponent<Image>();
		timesUpText.SetActive(false);
		timerBar.enabled = false;
		timeLeft = maxTime;
	}
	
	public void Began(){
		timerIsRunning = true;
	}
	
	public void Stop(){
		timerIsRunning = false;
		timerBar.enabled = false;
		maxTime = 7f;
		timeLeft = maxTime;
	}
	
	IEnumerator ShowAndHide(){
		timesUpText.SetActive(true);
		yield return new WaitForSeconds(1f);
		timesUpText.SetActive(false);
	}
   
    // Update is called once per frame
    void Update()
    {
		if(timerIsRunning)
		{
			timerBar.enabled = true;
			if(timeLeft > 0)
			{
				timeLeft -= Time.deltaTime;
				timerBar.fillAmount = timeLeft / maxTime;
		    }
			else
			{
				StartCoroutine(ShowAndHide());
				timerIsRunning = false;
				timerBar.enabled = false;
				maxTime = 5f;
				timeLeft = maxTime;
				scoreScreenTin.SetActive(false);
				scoreScreenPaper.SetActive(false);
				scoreScreenGlass.SetActive(false);
				buttonLeft.SetActive(true);
				buttonRight.SetActive(true);
				buttonJump.SetActive(true);
				ItemManager.itemAmount += 1;	
			}
		}
    }
}
