using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinearDialouge : Dialogue
{
    private void OnGUI()
    {
        //if our dialouge can be seen on screen
        if (showDialogue)
        {
            // the dialouge box takes up the whole bottom 3rd of the screen and displays the NPC's name and current dialouge line
            //GUI.Box(UIHandler.ScreenPlacement(4, 6, 8, 2),"");
            GUI.Box(UIHandler.ScreenPlacement(4, 6, 8, 12), speakersName + ": " + dialogueText[currentLineOfText]);

            //if not at the end of the dialouge
            if (currentLineOfText < dialogueText.Length - 1)
            {

                //next btton allws us to skip forward to the next line of dialouge
                if (GUI.Button(UIHandler.ScreenPlacement(7, 7.75f, 2, 1), " Next "))
                {

                    //incrementing currentLineIndex by 1 so that we go to next line
                    currentLineOfText++;

                }

            }


            //else we are at the end
            else
            {
                //the Bye button alows us to end our dialouge
                if (GUI.Button(UIHandler.ScreenPlacement(7, 7.75f, 2, 1), " Bye! "))
                {
                    //close the dialouge box
                    CloseDialouge();

                }
            }
        }
    }
}
