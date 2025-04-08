using System;
using UnityEngine;

public class CardFloat : MonoBehaviour
{
    public Transform transform1;
    Boolean movingUp;
    int range = 75;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movingUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(movingUp)
        {
            transform1.Translate(new Vector3(0, 1, 0));
        } else
        {
            transform1.Translate(new Vector3(0, -1, 0));
        }
        if(transform1.position.y >= range)
        {
            movingUp = false;
        }
        if(transform1.position.y <= 0)
        {
            movingUp = true;
        }
    }

    private void OnMouseDown()
    {
        this.enabled = false;
    }
}
