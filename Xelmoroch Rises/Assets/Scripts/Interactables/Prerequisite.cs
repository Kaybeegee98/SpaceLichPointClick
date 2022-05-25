using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prerequisite : MonoBehaviour
{
    public BoxPuzzle checkBox;
    public bool nodeAccess;
    public bool Complete
    { 
        get { return checkBox.activated; } 
    }
}
