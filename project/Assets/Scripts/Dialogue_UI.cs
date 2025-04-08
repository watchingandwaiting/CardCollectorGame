using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue_UI : MonoBehaviour
{
    string text;
    public string opening;
    int textIndex = 0;
    int frameCounter = 0;
    int openTime;
    RawImage box;
    static Boolean printing = false;
    TextMeshProUGUI currentText;
    

    public void Start()
    {
        Application.targetFrameRate = 100;
        box = this.GetComponentInChildren<RawImage>();
        currentText = this.GetComponentInChildren<TextMeshProUGUI>();
        textIndex = 0;
        text = "placeholder111111111111111111111111111111111111111111111111111111111";
        closeDialogue();
        startup();
    }

    private void startup()
    {
        openDialogue(opening);
    }

    public void Update()
    {
        frameCounter++;
        printing = (textIndex <= text.Length);
        if(printing && !box.IsActive())
        {
            printing = false;
        }
        if(printing && frameCounter % 3 == 0)
        {
            writeNextLetter();
        }
        
        if(box.IsActive() && !printing)
        {
            openTime++;
            if(openTime > 200)
            {
                closeDialogue();
            }
        }

        
    }

    private void writeNextLetter()
    {
        currentText.SetText(text.Substring(0, textIndex));
        textIndex++;
    }

    public Boolean openDialogue(String text)
    {
        if(printing)
        {
            return false;
        }
        this.text = text;
        textIndex = 0;
        box.enabled = true;
        currentText.enabled = true;
        return true;
    }

    private void closeDialogue()
    {
        box.enabled = false;
        currentText.enabled = false;
        openTime = 0;
    }
    
    //not working for some reason. implemented auto close instead
    public void OnMouseDown()
    {
        print("textbox clicked");
        if(printing)
        {
            currentText.SetText(text);
            printing = false;
        } else
        {
            closeDialogue();
        }
    }

}
