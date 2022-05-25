using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CodeSceneLoad : MonoBehaviour
{
    public InputField inputtedCode;

    void Start() {
    }

    public void CheckCodeAndLoad() {
        if (inputtedCode.text.Trim().ToLower() == "phantom") {
            SceneManager.LoadScene("ResumeRoomOne");
        }
    }
}
