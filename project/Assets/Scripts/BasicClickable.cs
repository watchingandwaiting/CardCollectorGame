using System;
using UnityEngine;

public class BasicClickable : MonoBehaviour
{
    public int interactCount;
    public String[] messages;
    Boolean outlining;
    public Outline outline;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactCount = 0;
        outline.OutlineWidth = 0;
        outline.OutlineColor = Color.green;
        if(messages == null)
        {
            messages = new string[] { "placeholder" };
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(outlining && outline.OutlineWidth < 10)
        {
            outline.OutlineWidth++;
        } else if(outline.OutlineWidth > 0)
        {
            outline.OutlineWidth--;
        }
    }

    //returns the String message associated with the interaction
    public String getMessage()
    {
        if(interactCount < messages.Length)
        {
            return messages[interactCount];
        } else
        {
            return messages[messages.Length - 1];
        }
    }
    private void OnMouseDown()
    {
        if(GameObject.FindAnyObjectByType<Dialogue_UI>().openDialogue(getMessage()))
        {
            interactCount++;
        }
    }

    private void OnMouseOver()
    {
        outlining = true;
    }
    private void OnMouseExit()
    {
        outlining = false;
    }
}
