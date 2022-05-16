using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealPath : MonoBehaviour
{
    public GameObject toBeMoved;
    public Transform endPoint;

    public Pedestal checkPedestal;

    private void Update()
    {
        if (checkPedestal.completed)
        {
            toBeMoved.transform.position = Vector3.MoveTowards(toBeMoved.transform.position, endPoint.position, (Time.deltaTime * 2));
        }
    }
}
