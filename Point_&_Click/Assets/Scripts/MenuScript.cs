using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private InputField inputtedCode;

    void Start() {
        inputtedCode = GetComponent<InputField>();
    }

    public void CheckCodeAndLoad() {
        if (inputtedCode.text.Trim().ToLower() == "phantom") {
            SceneManager.LoadScene("Skip_To_Room_Two");
        }
    }
}
