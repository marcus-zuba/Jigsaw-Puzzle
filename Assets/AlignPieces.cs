using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AlignPieces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        randomizeAndAlignPieces();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void randomizeAndAlignPieces()
    {
        int checkedPieces = 0;
        int y = 7;
        bool[] checkedP = Enumerable.Repeat(false, 25).ToArray();
        while (checkedPieces != 25)
        {
            int randomChildId = UnityEngine.Random.Range(0, transform.childCount);
            Transform randomChild = transform.GetChild(randomChildId);
            if (checkedP[randomChildId] == false)
            {
                checkedP[randomChildId] = true;
                checkedPieces++;
                randomChild.transform.localPosition = new Vector2(-5, y);
                y -= 6;
            }    
        }
        }
}
