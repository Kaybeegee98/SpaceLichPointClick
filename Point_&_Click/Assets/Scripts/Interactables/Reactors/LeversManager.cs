using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeversManager : MonoBehaviour
{
    public Switcher lever1;
    public Switcher lever2;
    public Switcher lever3;
    public Switcher lever4;

    public Transform sphere;
    public Transform endPoint;

    public void Update()
    {
        if (lever1.state && lever2.state && !(lever3.state) && lever4.state)
        {
            lever1.TurnOff();
            lever2.TurnOff();
            lever3.TurnOff();
            lever4.TurnOff();

            if (sphere != null)
            {
                sphere.position = Vector3.MoveTowards(sphere.position, endPoint.position, Time.deltaTime);
            }
        }
    }
}
