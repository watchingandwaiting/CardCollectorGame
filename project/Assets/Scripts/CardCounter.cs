using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardCounter : MonoBehaviour
{
    public static int CardCount = 0;
    public int allCollectedNum;
    GameObject mapButton;
    public string message;

    public void Start()
    {
        mapButton = this.gameObject.GetComponent<Transform>().GetChild(0).gameObject;
        print(mapButton.name);
    }
    public void Update()
    {
        this.GetComponent<TextMeshProUGUI>().SetText("" + CardCount);
    }

    public void increment()
    {
        CardCount++;
        //when reaches 12 : victory screen
        if(CardCount == allCollectedNum)
        {
            mapButton.SetActive(true);
            GameObject.FindAnyObjectByType<Dialogue_UI>().openDialogue(message);
        }
    }

}
