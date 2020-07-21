using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameOptionsControl : MonoBehaviour
{
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
        print("entrou aqui carai");
        if(gameObject.name == "PlayAgain Text")
        {
            SceneManager.LoadScene("mainpuzzlemenu");
        }
        else if(gameObject.name == "Exit Text")
        {
            Application.Quit();
        }
    }
}
