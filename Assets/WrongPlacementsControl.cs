using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongPlacementsControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = ("Wrong Placements: " + GameMaster.wrongPlacements);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
