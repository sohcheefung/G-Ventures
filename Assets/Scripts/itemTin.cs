using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemTin : MonoBehaviour
{
	private scoreManagerTin tin;
	
	
	void Start(){
		tin = GameObject.FindGameObjectWithTag("orange").GetComponent<scoreManagerTin>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
		tin.pausetoscore();
		Destroy (gameObject);
		}
	}
	
   

   
}
