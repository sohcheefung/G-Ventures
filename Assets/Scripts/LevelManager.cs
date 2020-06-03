using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public GameObject currentCheckpoint;
	
	public GameObject lastCheckPoint;
	
	private PlayerMovement player;
	
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void RespawnPlayer()
	{
		Debug.Log("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
	}
	
	public void reStart() {
		Scene scene;
		scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
		
	}
	
	
}
