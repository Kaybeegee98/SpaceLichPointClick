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
        GameObject.Find("Button_Right").GetComponent<Button>().onClick.AddListener(RightTurn);
        GameObject.Find("Button_Left").GetComponent<Button>().onClick.AddListener(LeftTurn);
        GameObject.Find("Button_Top").GetComponent<Button>().onClick.AddListener(LookUp);
        GameObject.Find("Button_Down").GetComponent<Button>().onClick.AddListener(LookDown);
    }

    private void RightTurn()
    {
        Sequence seq = DOTween.Sequence();

        if (direction == "up" || direction == "down")
        {
            return;
        }

        if (direction == "north")
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
    }

    private void LeftTurn()
    {
        Sequence seq = DOTween.Sequence();

        if (direction == "up" || direction == "down")
        {
            return;
        }

        if (direction == "north")
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
    }

    private void LookUp()
    {
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
    }

    private void LookDown()
    {
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
    }
}
