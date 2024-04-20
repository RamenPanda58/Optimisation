
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.SceneManagement;

public class DoorPuzzle : MonoBehaviour
{
    private PlayableDirector director;
    private bool isPlaying;
    public GameObject CameraPlayer;
    public GameObject CameraCutScene;

  



    void Start()
    {

        director = GetComponent<PlayableDirector>();
       isPlaying = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Hey");
            CameraPlayer.SetActive(false);
            CameraCutScene.SetActive(true);
            isPlaying = true;
            director.Play();
        }
    }
  
}