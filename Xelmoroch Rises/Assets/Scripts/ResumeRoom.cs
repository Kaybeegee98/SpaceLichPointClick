using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeRoom : MonoBehaviour
{
    //Lever Puzzle
    public LeversManager levManager;

    //Fishing Puzzle
    public fishing_minigame fishMini;

    //Roof Puzzle
    public RotateRing ringInner;
    public RotateRing ringMiddle;
    public RotateRing ringOuter;

    //Matching Puzzle
    public MatchSystemManager matchManager;
    public List<Transform> MoveablePairs;
    public List<Transform> Ports;

    //Turn on Door Camera
    public BoxPuzzle boxPuzzle;

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


        //Matching Puzzle
        matchManager.orb = null;
        matchManager.click = null;

        for (int i = 0; i < 4; i++)
        {
            MoveablePairs[i].transform.position = Ports[i].transform.position;
        }

        //Door Camera On
        if (boxPuzzle.activated != true)
        {
            boxPuzzle.activated = true;
            boxPuzzle.GetComponent<Location>().Arrive();
        }
    }
}
