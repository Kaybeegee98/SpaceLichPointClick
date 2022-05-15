using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Room : Node
{
    public UIControl uiControl;

    public void Awake()
    {
        uiControl.GetComponent<Canvas>().enabled = false;
    }

    public override void Arrive()
    {
        uiControl.GetComponent<Canvas>().enabled = true;

        Debug.Log("Room Arrive");

        if (GameManager.ins.currentNode != null)
        {
            GameManager.ins.currentNode.Leave();
        }

        GameManager.ins.currentNode = this;
        Sequence seq = DOTween.Sequence();

        switch (uiControl.direction)
        {
            case ("north"):
                seq.Append(Camera.main.transform.DOMove(uiControl.north.position, 0.75f));
                seq.Join(Camera.main.transform.DORotate(uiControl.north.rotation.eulerAngles, 0.75f));
                break;

            case ("west"):
                seq.Append(Camera.main.transform.DOMove(uiControl.west.position, 0.75f));
                seq.Join(Camera.main.transform.DORotate(uiControl.west.rotation.eulerAngles, 0.75f));
                break;

            case ("south"):
                seq.Append(Camera.main.transform.DOMove(uiControl.south.position, 0.75f));
                seq.Join(Camera.main.transform.DORotate(uiControl.south.rotation.eulerAngles, 0.75f));
                break;

            case ("east"):
                seq.Append(Camera.main.transform.DOMove(uiControl.east.position, 0.75f));
                seq.Join(Camera.main.transform.DORotate(uiControl.east.rotation.eulerAngles, 0.75f));
                break;
        }

        if (col != null)
        {
            col.enabled = false;
        }

        SetReachableNodes(true);
    }

    public override void Leave()
    {
        uiControl.GetComponent<Canvas>().enabled = false;

        base.Leave();
    }
}
