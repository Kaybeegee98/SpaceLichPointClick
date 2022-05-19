using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLocation : Location
{
    public LevelChanger levelChange;
    public override void Arrive()
    {
        base.Arrive();
        Invoke("TutorialOver", 1f);
    }

    public void TutorialOver()
    {
        levelChange.FadetoLevel();     
    }
}
