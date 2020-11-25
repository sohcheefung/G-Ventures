using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cpCounter : MonoBehaviour
{
	
	Text text;
	public static int checkpointCounter;
	
    // Start is called before the first frame update
    void Start()
    {
        checkpointCounter = 0;
		text = GetComponent<Text> ();
		text.text = checkpointCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
		text.text = "x" + checkpointCounter.ToString() + "/3";
    }
}
