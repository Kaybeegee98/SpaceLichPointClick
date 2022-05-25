using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeRoom : MonoBehaviour
{
    public LeversManager levManager;
    public fishing_minigame fishMini;

    public RotateRing ringMiddle;
    public RotateRing ringInner;

    [HideInInspector]
    private bool phase1 = false;

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
        while (ringMiddle.complete != true)
        {

            if (phase1 != true)
            {
                for (int i = 0; i < 2; i++)
                {
                    ringMiddle.transform.Rotate(ringMiddle.rotation);
                }
            }
        }
    }
}
