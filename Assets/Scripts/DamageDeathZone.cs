using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDeathZone : MonoBehaviour
{
    private PlayerMovement player;
	
	void Start(){
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
		
	}
	
	void OnTriggerEnter2D(Collider2D col){
	
		if(col.CompareTag("Player")){
			player.Damage(1);
			}
		}
}
