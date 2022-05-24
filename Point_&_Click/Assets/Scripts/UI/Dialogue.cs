using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public string dialogueText;
    public Text textBox;
    public static bool doorOpen;
    public static bool lichSeal;
    public bool doorOpened = false;
    public bool lichSealed = false;
    public GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test update display running");
        // GetComponent<Typewriter>().Run("typewriter test", textBox);
        // dialogueText.text = "Test\n second line";
    }

    void Update() 
    {
        doorOpen = DoorPuzzle.doorOpen;
        lichSeal = SealLich.lichSealed;

        if (doorOpen && !doorOpened) {
            StartCoroutine(doorDialogue());
            doorOpened = true;
        }

        if (lichSeal && !lichSealed) {
            StartCoroutine(endDialogue());
            lichSealed = true;
        }
    }





    // Update is called once per frame
    // public void UpdateDisplay()
    // {
    //     Debug.Log("update display running");
    //     dialogueText = "Turn back...";
    //     textBox.text = dialogueText;
    //     dialogueText = "typerwriter test back...";
    //     GetComponent<Typewriter>().Run(dialogueText, textBox);
    //     Debug.Log("second update display running");
    //     // 

    //     // if (doorOpen) {
    //     //     // dialogueText = "Turn back...";
    //     //     // GetComponent<Typewriter>().Run(dialogueText, textBox);
    //     //     firstDialogue();
    //     //     // dialogueText = "Turn back...";
    //     //     // GetComponent<Typewriter>().Run(dialogueText, textBox);
    //     //     // yield return new WaitForSeconds(2);
    //     // }
        
    //     // if (lichSealed) {
            // textBox.color = Color.magenta;
            // dialogueText = "Congratulations! you have successfully recaptured Xelmoroch";
            // dialogueText = "We cannot thank you enough for aiding us. Now it can begin.";
            // dialogueText = "Now that your pesky saviour is imprisoned permanently, we can now begin preparing...";
            // dialogueText = "Preparing for the invasion of your world";
            // dialogueText = "Mankind’s end is imminent";
    //     // }
    // }

    // public void StartDialogue() {
    //     dialogueText = "Turn back...";
    //     textBox.text = dialogueText;
    // }

    private IEnumerator doorDialogue() {        
        panel.SetActive(true);
        
        // textBox.color = Color.white;
        dialogueText = "Xelmoroch:  Turn back...";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(4);
        // dialogueText = "Xelmoroch:  You will regret this.";
        // GetComponent<Typewriter>().Run(dialogueText, textBox);
        // yield return new WaitForSeconds(6);
        // dialogueText = "Xelmoroch:  End will come to your species.";
        // GetComponent<Typewriter>().Run(dialogueText, textBox);
        // yield return new WaitForSeconds(8);
        dialogueText = "Xelmoroch:  All is not as it seems...";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(8);

        dialogueText = "Unknown:  Ignore the lich!";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(5);

        // dialogueText = "Xelmoroch:  Turn ba...";
        // GetComponent<Typewriter>().Run(dialogueText, textBox);
        // yield return new WaitForSeconds(3);
 
        // dialogueText = "Unknown:  Silence Lich!";
        // GetComponent<Typewriter>().Run(dialogueText, textBox);
        // yield return new WaitForSeconds(3);
        dialogueText = "Unknown:  Move quickly, there is still time to stop him!";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(11);

        dialogueText = "";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(2);

        panel.SetActive(false);
    }

    private IEnumerator endDialogue() {        
        panel.SetActive(true);
        
        dialogueText = "Unknown:  Congratulations! You have successfully recaptured Xelmoroch!";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(8);
        dialogueText = "Unknown:  We cannot thank you enough for aiding us. Now it can begin.";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(14);
        dialogueText = "Unknown:  Now that your pesky saviour is imprisoned permanently, we can now begin preparing...";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(15);
        dialogueText = "Unknown:  Preparing for the invasion of your world.";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(8);
        dialogueText = "Unknown:  Mankind's end is imminent.";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(6);

        dialogueText = "";
        GetComponent<Typewriter>().Run(dialogueText, textBox);
        yield return new WaitForSeconds(2);

        panel.SetActive(false);
    }
}
