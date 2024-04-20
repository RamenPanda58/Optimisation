﻿using UnityEngine;
using EZCameraShake;

public class ShakeOnKeyPress : MonoBehaviour
{
    public float Magnitude = 2f;
    public float Roughness = 10f;
    public float FadeOutTime = 5f;

	void Update ()
    {
	  if(Input.GetKeyDown(KeyCode.I))
      {
              CameraShaker.Instance.ShakeOnce(Magnitude, Roughness, 0, FadeOutTime);
      
      }
	}
}
