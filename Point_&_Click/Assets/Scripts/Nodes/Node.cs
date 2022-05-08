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

    public virtual void Arrive()
    {
        if(GameManager.ins.currentNode != null)
        {
            GameManager.ins.currentNode.Leave();
        }

        GameManager.ins.currentNode = this;

        Sequence seq = DOTween.Sequence();
        seq.Append(Camera.main.transform.DOMove(cameraPosition.position, 0.75f));
        seq.Join(Camera.main.transform.DORotate(cameraPosition.rotation.eulerAngles, 0.75f));

        if (col != null)
        {
            col.enabled = false;
        }

        SetReachableNodes(true);
    }

    public virtual void Leave()
    {
        SetReachableNodes(false);
    }

    public void SetReachableNodes(bool set)
    {
        foreach (Node node in reachableNodes)
        {
            if (node.col != null)
            {
                if (node.GetComponent<Prerequisite>() && node.GetComponent<Prerequisite>().nodeAccess)
                {
                    if (node.GetComponent<Prerequisite>().Complete)
                    {
                        node.col.enabled = set;
                        Debug.Log("Complete");
                    }
                    else
                    {
                       Debug.Log("No Complete");
                    }
                }
                else
                {
                    Debug.Log("No check");
                    node.col.enabled = set;
                }
            }
        }
    }
}
