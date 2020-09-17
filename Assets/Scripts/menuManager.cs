using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
	
	public void loadLevelSelection(string level){
		//SceneManager.UnloadSceneAsync ("Menu");
		SceneManager.LoadScene("level");
	}
	
	public void loadMenu(string Menu){
		SceneManager.LoadScene("Menu");
	}
	
	public void loadLevel1(string level1){
		SceneManager.LoadScene("level1");
	}
	
	public void loadLevel2(string level2){
		SceneManager.LoadScene("level2");
	}
	
	public void loadLevel3(string level3){
		SceneManager.LoadScene("level3");
	}
	
	public void loadLevel4(string level4){
		SceneManager.LoadScene("level4");
	}
	
	public void loadLevel5(string level5){
		SceneManager.LoadScene("level5");
	}
	
	public void loadCredit(string credit){
		SceneManager.LoadScene("credit");
	}
	
	public void Quit(){
		Application.Quit();
	}

    // Update is called once per frame
   
}
