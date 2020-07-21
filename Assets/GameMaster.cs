using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

    public static float timeBonus;

    public static int totalScore;

    public static int piecesLocked;

    public static int wrongPlacements;


    // Start is called before the first frame update
    void Start()
    {
        timeBonus = 120;
        piecesLocked = 0;
        totalScore = 0;
        wrongPlacements = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBonus > 0)
        {
            timeBonus -= Time.deltaTime;
        }
        if(piecesLocked == 25)
        {
            totalScore += (int)timeBonus;
            SceneManager.LoadScene("levelcomplete");
        }
    }

    public static void increaseScore()
    {
        totalScore += 25 - piecesLocked;
        piecesLocked++;
    }

    public static void deacreseScore()
    {
        totalScore -= piecesLocked;
    }
}
