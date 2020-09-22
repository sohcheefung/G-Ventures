using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public GameObject currentCheckpoint;
	
	public GameObject lastCheckPoint;
	
	private PlayerMovement player;
	
	public AudioSource deathSound;
	
    // Start is called before the first frame update
    void Start()
    {
		//Time.timeScale = 1f;
        player = FindObjectOfType<PlayerMovement>();
		deathSound = GetComponent<AudioSource>();
    }

	
	public void RespawnPlayer()
	{
		Debug.Log("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
		deathSound.Play();
		
	}
	
	public void reStart() {
		Time.timeScale = 1f;
		Scene scene;
		scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
		
	}
	
	
}
