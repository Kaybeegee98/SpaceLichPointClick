using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract class Node : MonoBehaviour
{

    public Transform cameraPosition;
    public List<Node> reachableNodes = new List<Node>();

    [HideInInspector]
    public Collider col;

    void Start()
    {
        col = GetComponent<Collider>();
    }

    void OnMouseDown()
    {
        Arrive();
    }

    public void Arrive()
    {
        if(GameManager.ins.currentNode != null)
        {
            GameManager.ins.currentNode.Leave();
        }

        GameManager.ins.currentNode = this;

        Sequence seq = DOTween.Sequence();
        seq.Append(Camera.main.transform.DOMove(cameraPosition.position, 0.75f));
        seq.Join(Camera.main.transform.DORotate(cameraPosition.rotation.eulerAngles, 0.75f));

        //Camera.main.transform.position = cameraPosition.position;
        //Camera.main.transform.rotation = cameraPosition.rotation;

        if(col != null)
        {
            col.enabled = false;
        }

        foreach (Node node in reachableNodes)
        {
            if (node.col != null)
            {
                node.col.enabled = true;
            }
        }
    }

    public void Leave()
    {
        foreach (Node node in reachableNodes)
        {
            if (node.col != null)
            {
                node.col.enabled = false;
            }
        }
    }
}
