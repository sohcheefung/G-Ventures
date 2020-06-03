using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemGlass : MonoBehaviour
{
    private scoreManagerGlass glass;
	
	void Start(){
		glass = GameObject.FindGameObjectWithTag("brown").GetComponent<scoreManagerGlass>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
		glass.pausetoscore();
		Destroy (gameObject);
		}
	}
}
