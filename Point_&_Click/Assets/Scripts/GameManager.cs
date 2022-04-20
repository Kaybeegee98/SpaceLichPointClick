using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;

    [HideInInspector]
    public Node currentNode;

    void Awake()
    {
        ins = this;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(1) && currentNode.GetComponent<Location>() != null)
        {
            currentNode.GetComponent<Location>().room.Arrive();
        }
        else if (Input.GetMouseButtonUp(1) && currentNode.GetComponent<Prop>() != null)
        {
            currentNode.GetComponent<Prop>().loc.Arrive();
        }
    }
}
