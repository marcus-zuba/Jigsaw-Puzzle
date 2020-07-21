using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour { 

    public static int whichLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(gameObject.name=="Level 1 text")
        {
            whichLevel = 1;
        }
        else if (gameObject.name == "Level 2 text")
        {
            whichLevel = 2;
        }
        SceneManager.LoadScene("puzzle1");
    }
}
