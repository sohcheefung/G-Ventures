using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_button : MonoBehaviour
{
    public void play_sound(int s){
		AudioVolumeControl.instance.s_playsound(s);
	}
}
