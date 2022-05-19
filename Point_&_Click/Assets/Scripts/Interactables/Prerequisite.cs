using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prerequisite : MonoBehaviour
{
    public Switcher checkSwitch;
    public bool nodeAccess;
    public bool Complete
    { 
        get { return checkSwitch.state; } 
    }
}
