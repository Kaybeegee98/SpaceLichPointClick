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

    public string direction = "north";

    private void Start()
    {
        GameObject.Find("Button_Right").GetComponent<Button>().onClick.AddListener(RightTurn);
        GameObject.Find("Button_Left").GetComponent<Button>().onClick.AddListener(LeftTurn);
    }

    private void RightTurn()
    {
        Sequence seq = DOTween.Sequence();

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
}
