using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : Node
{
    public UIControl uiControl;

    public override void Arrive()
    {
        uiControl.GetComponent<Canvas>().enabled = true;

        base.Arrive();
    }

    public override void Leave()
    {
        uiControl.GetComponent<Canvas>().enabled = false;
        uiControl.direction = "north";

        base.Leave();
    }
}
