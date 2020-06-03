using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemManager : MonoBehaviour
{
    
	Text text;
	public static int itemAmount;
	
	void Start()
	{
		itemAmount = 0;
		text = GetComponent<Text> ();
	}
	
	void Update () {
		text.text = "x" + itemAmount.ToString();
	}
}
