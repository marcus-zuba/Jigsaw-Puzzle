using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalImageControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite secondLevelImage;
    void Start()
    {
        if (LevelSelect.whichLevel == 2)
        {
            GetComponent<SpriteRenderer>().sprite = secondLevelImage;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
