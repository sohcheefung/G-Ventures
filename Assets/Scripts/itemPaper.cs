using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemPaper : MonoBehaviour
{
    private scoreManagerPaper paper;
	
	void Start(){
		paper = GameObject.FindGameObjectWithTag("blue").GetComponent<scoreManagerPaper>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
		paper.pausetoscore();
		Destroy (gameObject);
		}
	}
}
