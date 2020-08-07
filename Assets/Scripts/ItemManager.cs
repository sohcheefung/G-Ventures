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
		text.text = itemAmount.ToString();
	}
	
	void Update () {
		PlayerPrefs.SetInt("TotalItem", itemAmount);
		text.text = "x" + itemAmount.ToString() + "/10";
	}
}
