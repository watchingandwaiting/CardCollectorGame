using System;
using UnityEngine;

public class CardCollectScript : MonoBehaviour
{
    public String cardName;
    public void deactivateCard()
    {
        GameObject card = GetComponentInParent<GameObject>();
        card.SetActive(false);
    }

    
}
