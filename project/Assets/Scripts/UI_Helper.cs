using UnityEngine;

public class UI_Helper : MonoBehaviour
{
    public void OnMouseDown()
    {
        print("mouseclick");
        this.GetComponentInParent<Dialogue_UI>().OnMouseDown();
    }
}
