using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    public string pieceStatus;

    public Transform edgeParticles;

    public KeyCode placePiece;
    public KeyCode returnToInv;

    public string checkPlacement;

    public float yDiff;

    public Vector2 invPos;

    public Sprite stage2Image;


    // Start is called before the first frame update
    void Start()
    {
        pieceStatus = "idle";
        checkPlacement = "n";
        yDiff = 0;
        if (LevelSelect.whichLevel == 2)
        {
            GetComponent<SpriteRenderer>().sprite = stage2Image;
        }
    }

    // Update is called once per frame
    void Update()
    {
        invControl();

        if (pieceStatus == "pickedup")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;

        }

        if (Input.GetKeyDown(placePiece) && pieceStatus == "pickedup")
        {
            checkPlacement = "y";
        }
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == gameObject.name && checkPlacement=="y")
        {
            other.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Renderer>().sortingOrder = 0;
            transform.position = other.gameObject.transform.position;
            transform.position = new Vector3(transform.position.x, transform.position.y, -20);
            pieceStatus = "locked";
            Instantiate(edgeParticles, other.gameObject.transform.position,edgeParticles.rotation);
            checkPlacement = "n";
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            GameMaster.increaseScore();
        }
        if (other.gameObject.name != gameObject.name && checkPlacement == "y")
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .5f);
            checkPlacement = "n";
            GameMaster.deacreseScore();
            GameMaster.wrongPlacements++;
        }


    }

    private void OnMouseDown()
    {
        if(pieceStatus == "idle")
        {
            pieceStatus = "pickedup";
            checkPlacement = "n";
            GetComponent<Renderer>().sortingOrder = 10;
            invPos = transform.localPosition;
        }
        else if(pieceStatus == "pickedup")
        {
            pieceStatus = "idle";
            transform.localPosition = new Vector2(-5, invPos.y + yDiff);
        }
    }

    void invControl()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (pieceStatus == "pickedup"){
                yDiff -= 6;
            }
            if (pieceStatus == "idle")
            {
                    transform.localPosition = new Vector2(-5, transform.localPosition.y - 6);
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if(pieceStatus == "pickedup")
            {
                yDiff += 6;
            }
            if (pieceStatus == "idle")
            {
                transform.localPosition = new Vector2(-5, transform.localPosition.y + 6);
            }
        }
        if(pieceStatus == "idle")
        {
            transform.localPosition = new Vector2(-5, transform.localPosition.y + Arrows.invAdj);
            Arrows.notifyChange();
        }
    }


}
