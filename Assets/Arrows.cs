using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    private static int piecesChanged;
    public static float invAdj;

    // Start is called before the first frame update
    void Start()
    {
        piecesChanged = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print("chegou aqui doido");
        if(gameObject.name == "ArrowDown")
        {
            invAdj -= 6;
        }
        else if(gameObject.name == "ArrowUp")
        {
            invAdj += 6;
        }
    }

    public static void notifyChange() {
        piecesChanged++;
        if(piecesChanged == 25)
        {
            piecesChanged = 0;
            invAdj = 0;
        }
    }
}
