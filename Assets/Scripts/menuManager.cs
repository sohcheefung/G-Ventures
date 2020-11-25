using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
	public static bool exitPanel = false;
	
	public GameObject ExitPanel;
	public GameObject InfoPanel;
	
	public GameObject loadingScreen;
	public Slider slider;
	
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
	
	public void openInfo(){
		InfoPanel.SetActive(true);
	}
	
	public void closeInfo(){
		InfoPanel.SetActive(false); 
	}
	
	public void loadLevelSelection(string level){
		//SceneManager.UnloadSceneAsync ("Menu");
		SceneManager.LoadScene("level");
	}
	
	public void loadMenu(string Menu){
		SceneManager.LoadScene("Menu");
	}
	
	public void LoadLevel (int sceneIndex)
	{
			StartCoroutine(LoadAsynchronously(sceneIndex));
	}
	
	IEnumerator LoadAsynchronously (int sceneIndex)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
		
		loadingScreen.SetActive(true);
		
		while (!operation.isDone)
		{
				float progress = Mathf.Clamp01(operation.progress / .9f);
				slider.value = progress;
				//yield return new WaitForSeconds(1f);
				yield return null;
		}
	}
	
	public void loadCredit(string credit){
		SceneManager.LoadScene("credit");
	}
	
	public void Quit(){
		ExitPanel.SetActive(true);
		exitPanel = true;
	}
	
	public void No(){
		ExitPanel.SetActive(false);
		exitPanel = false;
	}

	public void Yes(){
		Application.Quit();
	}
    // Update is called once per frame
   
}
