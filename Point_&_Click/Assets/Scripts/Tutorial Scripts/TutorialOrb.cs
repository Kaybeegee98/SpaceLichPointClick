using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialOrb : CollectOrb
{
    public bool activated = false;

    public override void OnMouseDown()
    {
        if (activated == true)
        {
            Interact();
        }
    }
}
