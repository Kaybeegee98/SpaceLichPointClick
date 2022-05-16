using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialProp : Prop
{
    public CollectOrb collectOrb;
    public override void Arrive()
    {
        base.Arrive();

        //collectOrb.activated = true;
    }
    public override void Leave()
    {
        base.Leave();

        if (GameObject.FindGameObjectWithTag("Orb"))
        {
            //collectOrb.activated = false;
        }
    }
}
