using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public static bool GameIsPaused = false;
   
   
   public GameObject buttonLeft;
   public GameObject buttonRight;
   public GameObject buttonJump;
   public GameObject pauseMenuUI;

    // Update is called once per frame
    public void PauseIcon()
    {
		
			if (GameIsPaused)
			{
				Resume();
			}else
			{
				Pause();
			}
    }
	
	public void Resume (){
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		buttonLeft.SetActive(true);
		buttonRight.SetActive(true);
		buttonJump.SetActive(true);
	}
	
	void Pause (){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		buttonLeft.SetActive(false);
		buttonRight.SetActive(false);
		buttonJump.SetActive(false);
		
	}
	
	public void LoadMenu()
	{
		Debug.Log("Loading menu...");
		Application.LoadLevel("Menu");
	}
	
	public void QuitGame()
	{
		Debug.Log("Quitting game...");
		Application.Quit();
	}
	
	public void loadLevel1(string level1){
		Time.timeScale = 1f;
		SceneManager.LoadScene("level1");
	}
}    
