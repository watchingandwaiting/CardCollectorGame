using UnityEngine;

public class DresserVanish : BasicClickable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
        if (GameObject.FindAnyObjectByType<Dialogue_UI>().openDialogue(getMessage()))
        {
            interactCount++;
            this.GetComponentInParent<Transform>().position = new Vector3(1, -200);
        }
        //write to a file

    }
}
