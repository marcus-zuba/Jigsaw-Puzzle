using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScoreControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = ("Score: " + GameMaster.totalScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
