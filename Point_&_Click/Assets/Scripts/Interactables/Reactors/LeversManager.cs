using System.Collections.Generic;
using UnityEngine;

public class LeversManager : MonoBehaviour
{
    public Color deactivated;

    public List<Switcher> leverList;

    public Transform sphere;
    public Transform endPoint;

    public void Update()
    {
        if (leverList[0].state && leverList[1].state && !(leverList[2].state) && leverList[3].state)
        {
            foreach (Switcher s in leverList)
            {
                s.GetComponent<Collider>().enabled = false;
                s.GetComponentInChildren<MeshRenderer>().material.color = deactivated;
            }

            if (sphere != null)
            {
                sphere.position = Vector3.MoveTowards(sphere.position, endPoint.position, Time.deltaTime);
            }
        }
    }
}
