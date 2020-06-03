using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour{

	public LevelManager levelManager;
	
	private PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
		
        levelManager = FindObjectOfType<LevelManager>();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
			{
				player.Damage(1);
				levelManager.RespawnPlayer();
			}
	}
}
