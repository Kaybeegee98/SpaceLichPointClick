using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RevealPath : MonoBehaviour
{
    public GameObject toBeMoved;
    public Transform endPoint;
    public UIControl uiControl;

    public Pedestal checkPedestal;

    [HideInInspector]
    public bool force = false;

    private void Update()
    {
        if (force == false)
        {
            if (checkPedestal.completed)
            {
                toBeMoved.transform.position = Vector3.MoveTowards(toBeMoved.transform.position, endPoint.position, (Time.deltaTime * 2));
                ForceCamera();

                if (toBeMoved.transform.position == endPoint.position)
                {
                    StateReturn();
                }
            }
        }
    }

    private void ForceCamera()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(Camera.main.transform.DOMove(uiControl.north.position, 0.75f));
        seq.Join(Camera.main.transform.DORotate(uiControl.north.rotation.eulerAngles, 0.75f));

        uiControl.direction = "north";
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void StateReturn()
    {
        force = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
