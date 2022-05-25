using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeRoom : MonoBehaviour
{
    public LeversManager levManager;
    public fishing_minigame fishMini;

    public RotateRing ringInner;
    public RotateRing ringMiddle;
    public RotateRing ringOuter;

    [HideInInspector]
    private bool phase1 = false;
    private bool phase2 = false;

    public void Update()
    {
        //Levers Manager Finish
        foreach (Switcher s in levManager.leverList)
        {
            Destroy(s.GetComponent<Collider>());
            s.GetComponentInChildren<MeshRenderer>().material.color = levManager.deactivated;
        }

        //Fishing Puzzle Finish
        fishMini.click = null;
        fishMini.orb = null;
        fishMini.catchProgress = 1;

        //Roof Puzzle Finish
        if (phase1 != true)
        {
            for (int i = 0; i < 2; i++)
            {
                ringMiddle.transform.Rotate(ringMiddle.rotation);
            }

            phase1 = true;
        }

        if (phase2 != true)
        {
            for (int i = 0; i < 4; i++)
            {
                ringOuter.transform.Rotate(ringOuter.rotation);
            }

            phase2 = true;
        }
        Destroy(ringMiddle.GetComponent<Collider>());
        Destroy(ringOuter.GetComponent<Collider>());
        Destroy(ringInner.GetComponent<Collider>());
    }
}
