using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        Camera.main.transform.position = cameraPosition.position;
        Camera.main.transform.rotation = cameraPosition.rotation;

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
