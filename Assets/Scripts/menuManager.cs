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
	
	public void loadLevel1(string level1){
		//SceneManager.UnloadSceneAsync ("Menu");
		SceneManager.LoadScene("level1");
	}
	
	public void Quit(){
		Application.Quit();
	}

    // Update is called once per frame
   
}
