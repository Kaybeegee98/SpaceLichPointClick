using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Canvas))]
public class UIControl : MonoBehaviour
{
    public Transform north;
    public Transform east;
    public Transform south;
    public Transform west;
    public Transform up;
    public Transform down;


    public string direction = "north";

    private void Start()
    {
        Debug.Log("UI Started");
        GameObject.Find("Button_Right").GetComponent<Button>().onClick.AddListener(RightTurn);
        GameObject.Find("Button_Left").GetComponent<Button>().onClick.AddListener(LeftTurn);
        if (GameObject.Find("Button_Top"))
        {
            GameObject.Find("Button_Top").GetComponent<Button>().onClick.AddListener(LookUp);
        }
        if (GameObject.Find("Button_Down"))
        {
            GameObject.Find("Button_Down").GetComponent<Button>().onClick.AddListener(LookDown);
        }
    }

    private void Awake()
    {
        if ((Camera.main.transform == up.transform) || (Camera.main.transform == down.transform))
        {
            GameObject.Find("Button_Right").GetComponent<Button>().interactable = false;
            GameObject.Find("Button_Left").GetComponent<Button>().interactable = false;
        }
        else
        {
            GameObject.Find("Button_Right").GetComponent<Button>().interactable = true;
            GameObject.Find("Button_Left").GetComponent<Button>().interactable = true;
        }
    }

    public void RightTurn()
    {
        TimeoutClick();
        Sequence seq = DOTween.Sequence();

        if (direction == "up" || direction == "down")
        {
        }
        else if (direction == "north")
        {
            seq.Append(Camera.main.transform.DOMove(east.position, 0.75f));
            seq.Join(Camera.main.transform.DORotate(east.rotation.eulerAngles, 0.75f));

            direction = "east";
        }
        else if (direction == "east")
        {
            seq.Append(Camera.main.transform.DOMove(south.position, 0.75f));
            seq.Join(Camera.main.transform.DORotate(south.rotation.eulerAngles, 0.75f));

            direction = "south";
        }
        else if (direction == "south")
        {
            seq.Append(Camera.main.transform.DOMove(west.position, 0.75f));
            seq.Join(Camera.main.transform.DORotate(west.rotation.eulerAngles, 0.75f));

            direction = "west";
        }
        else
        {
            seq.Append(Camera.main.transform.DOMove(north.position, 0.75f));
            seq.Join(Camera.main.transform.DORotate(north.rotation.eulerAngles, 0.75f));

            direction = "north";
        }

        Debug.Log(direction);
        Invoke("TimeinClick", 0.75f);
    }

    private void LeftTurn()
    {
        TimeoutClick();
        Sequence seq = DOTween.Sequence();

        if (direction == "up" || direction == "down")
        {
        }
        else if (direction == "north")
        {
            seq.Append(Camera.main.transform.DOMove(west.position, 0.75f));
            seq.Join(Camera.main.transform.DORotate(west.rotation.eulerAngles, 0.75f));

            direction = "west";
        }
        else if (direction == "west")
        {
            seq.Append(Camera.main.transform.DOMove(south.position, 0.75f));
            seq.Join(Camera.main.transform.DORotate(south.rotation.eulerAngles, 0.75f));

            direction = "south";
        }
        else if (direction == "south")
        {
            seq.Append(Camera.main.transform.DOMove(east.position, 0.75f));
            seq.Join(Camera.main.transform.DORotate(east.rotation.eulerAngles, 0.75f));

            direction = "east";
        }
        else
        {
            seq.Append(Camera.main.transform.DOMove(north.position, 0.75f));
            seq.Join(Camera.main.transform.DORotate(north.rotation.eulerAngles, 0.75f));

            direction = "north";
        }

        Debug.Log(direction);
        Invoke("TimeinClick", 0.5f);
    }

    private void LookUp()
    {
        TimeoutClick();
        Sequence seq = DOTween.Sequence();

        if (direction != "up")
        {
            if (direction != "down")
            {
                seq.Append(Camera.main.transform.DOMove(up.position, 0.75f));
                seq.Join(Camera.main.transform.DORotate(up.rotation.eulerAngles, 0.75f));

                direction = "up";
            }
            else
            {
                seq.Append(Camera.main.transform.DOMove(north.position, 0.75f));
                seq.Join(Camera.main.transform.DORotate(north.rotation.eulerAngles, 0.75f));

                direction = "north";
            }
        }
        Invoke("TimeinClick", 0.5f);
    }

    private void LookDown()
    {
        TimeoutClick();
        Sequence seq = DOTween.Sequence();

        if (direction != "down")
        {
            if (direction != "up")
            {
                seq.Append(Camera.main.transform.DOMove(down.position, 0.75f));
                seq.Join(Camera.main.transform.DORotate(down.rotation.eulerAngles, 0.75f));

                direction = "down";
            }
            else
            {
                seq.Append(Camera.main.transform.DOMove(north.position, 0.75f));
                seq.Join(Camera.main.transform.DORotate(north.rotation.eulerAngles, 0.75f));

                direction = "north";
            }
        }
        Invoke("TimeinClick", 0.5f);
    }

    private void TimeoutClick()
    {
        GameObject.Find("Button_Right").GetComponent<Button>().interactable = false;
        GameObject.Find("Button_Left").GetComponent<Button>().interactable = false;

        if (GameObject.Find("Button_Top"))
        {
            GameObject.Find("Button_Top").GetComponent<Button>().interactable = false;
        }
        if (GameObject.Find("Button_Down"))
        {
            GameObject.Find("Button_Down").GetComponent<Button>().interactable = false;
        }
    }

    private void TimeinClick()
    {
        GameObject.Find("Button_Right").GetComponent<Button>().interactable = true;
        GameObject.Find("Button_Left").GetComponent<Button>().interactable = true;

        if (GameObject.Find("Button_Top"))
        {
            GameObject.Find("Button_Top").GetComponent<Button>().interactable = true;
        }
        if (GameObject.Find("Button_Down"))
        {
            GameObject.Find("Button_Down").GetComponent<Button>().interactable = true;
        }
    }
}
