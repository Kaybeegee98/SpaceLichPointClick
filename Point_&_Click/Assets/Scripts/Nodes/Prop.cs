using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : Node
{
    public Location loc;
    Interactable interact;

    private void Awake()
    {
        interact = GetComponent<Interactable>();
    }

    public override void Arrive()
    {
        if (interact != null && interact.enabled)
        {
            interact.Interact();
            return;
        }
        base.Arrive();

        if (interact != null)
        {
            if (GetComponent<Prerequisite>() && !GetComponent<Prerequisite>().Complete)
            {
                return;
            }
            col.enabled = true;
            interact.enabled = true;
        }
    }

    public override void Leave()
    {
        base.Leave();

        if (interact != null)
        {
            interact.enabled = false;
        }
    }
}
