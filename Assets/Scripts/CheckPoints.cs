using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
	public LevelManager levelManager;
	public Sprite redBin;
	public Sprite greenBin;
	private SpriteRenderer checkpointSpriteRenderer;
	public bool checkpointReached;
	
    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
		checkpointSpriteRenderer = GetComponent<SpriteRenderer> ();
    }

	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
			{
				levelManager.currentCheckpoint = gameObject;
				Debug.Log ("Activated Checkpoint " + transform.position);
				checkpointSpriteRenderer.sprite = greenBin;
				checkpointReached = true;
			}
	}
}
