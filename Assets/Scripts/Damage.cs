using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private PlayerMovement player;
	
	void Start(){
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
		
	}
	
	void OnTriggerEnter2D(Collider2D col){
	
		if(col.CompareTag("Player")){
			player.Damage(1);
			player.knockbackCount = player.knockbackLength;
			if(col.transform.position.x< transform.position.x)
				player.knockFromRight = true;
			else
				player.knockFromRight = false;
			}
		}
}
