using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastCheckPoint : MonoBehaviour
{
    public LevelManager levelManager;
	public Sprite redBin;
	public Sprite greenBin;
	private SpriteRenderer checkpointSpriteRenderer;
	public bool checkpointReached;
	public bool winGame = false;
	public GameObject winGameScreen;
	
    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
		checkpointSpriteRenderer = GetComponent<SpriteRenderer> ();
		winGameScreen.SetActive(false);
    }

	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
			{
				levelManager.lastCheckPoint = gameObject;
				Debug.Log ("Last Checkpoint Reached " + transform.position);
				checkpointSpriteRenderer.sprite = greenBin;
				checkpointReached = true;
				winGame = true;
				winGameScreen.SetActive(true);
				Time.timeScale = 0f;
				
			}
	}
}
