using UnityEngine;

public class CardRotateScript : MonoBehaviour
{
    public Transform card;
    int currentRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentRotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation -= 1;
        card.localRotation = Quaternion.Euler(0, currentRotation, 0);
    }
}
