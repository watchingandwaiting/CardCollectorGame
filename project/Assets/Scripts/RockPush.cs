using UnityEngine;

public class RockPush : BasicClickable
{

    private void OnMouseDown()
    {
        if (GameObject.FindAnyObjectByType<Dialogue_UI>().openDialogue(getMessage()))
        {
            interactCount++;
        }
        if(interactCount == 1)
        {
            this.gameObject.transform.Translate(new Vector3(0, 0, 15));
        }
    }
}
