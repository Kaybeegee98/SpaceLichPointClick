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
    public bool lichSealed;


    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<Typewriter>().Run("typewriter test", textBox);
        // dialogueText.text = "Test\n second line";
    }

    // Update is called once per frame
    public void UpdateDisplay()
    {
        dialogueText = "Turn back...";
        textBox.text = dialogueText;
        dialogueText = "typerwriter test back...";
        GetComponent<Typewriter>().Run(dialogueText, textBox);

        // doorOpen = DoorPuzzle.doorOpen;
        // Debug.Log(doorOpen);
        // if (doorOpen) {
        //     // dialogueText = "Turn back...";
        //     // GetComponent<Typewriter>().Run(dialogueText, textBox);
        //     firstDialogue();
        //     // dialogueText = "Turn back...";
        //     // GetComponent<Typewriter>().Run(dialogueText, textBox);
        //     // yield return new WaitForSeconds(2);
        // }
        
        // if (lichSealed) {
        //     textBox.color = Color.magenta;
        //     dialogueText = "Congratulations! you have successfully recaptured Xelmoroch";
        //     dialogueText = "We cannot thank you enough for aiding us. Now it can begin.";
        //     dialogueText = "Now that your pesky saviour is imprisoned permanently, we can now begin preparing...";
        //     dialogueText = "Preparing for the invasion of your world";
        //     dialogueText = "Mankind’s end is imminent";
        // }
    }

    // public void StartDialogue() {
    //     dialogueText = "Turn back...";
    //     textBox.text = dialogueText;
    // }

    private IEnumerator firstDialogue() {
        dialogueText = "Turn back...";
        textBox.text = dialogueText;
        yield return new WaitForSeconds(2);
        
        
        // textBox.color = Color.green;
        // dialogueText = "Turn back...";
        // GetComponent<Typewriter>().Run(dialogueText, textBox);
        // yield return new WaitForSeconds(2);
        // dialogueText = "You will regret this";
        // dialogueText = "End will come to your species";
        // dialogueText = "All is not as it seems...";

        // textBox.color = Color.magenta;
        // dialogueText = "Do not believe his threats, he is not strong enough yet";

        // textBox.color = Color.green;
        // dialogueText = "Turn Ba...";

        // textBox.color = Color.magenta;
        // dialogueText = "Silence Lich!";
        // dialogueText = "You may proceed.";
    }
}
