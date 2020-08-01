using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Help : MonoBehaviour
{
	public static bool HelpAppear = false;
	
	public GameObject buttonLeft;
	public GameObject buttonRight;
	public GameObject buttonJump;
	public GameObject HelpScreen;
	
    public void HelpButton()
	{
		HelpAppear = true;
		HelpScreen.SetActive(true);
		Time.timeScale = 0f;
		buttonLeft.SetActive(false);
		buttonRight.SetActive(false);
		buttonJump.SetActive(false);
	}
	
	public void Resume(){
		HelpAppear = false;
		HelpScreen.SetActive(false);
		Time.timeScale = 1f;
		buttonLeft.SetActive(true);
		buttonRight.SetActive(true);
		buttonJump.SetActive(true);
	}
}
