using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleToggles : MonoBehaviour
{
    public GameObject puzzledisk; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            // Rotate the puzzledisk GameObject by 60 degrees around the Y-axis
            puzzledisk.transform.Rotate(0f, 0f, 60f);
        }
    }
}
