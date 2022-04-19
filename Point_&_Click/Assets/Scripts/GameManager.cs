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
        if(Input.GetMouseButton(1) && currentNode.GetComponent<Prop>() != null)
        {
            currentNode.GetComponent<Prop>().loc.Arrive();
        }
    }
}
