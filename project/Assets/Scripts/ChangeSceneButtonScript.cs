using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ChangeSceneButtonScript : MonoBehaviour
{
    Button button;
    public string nextScene;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = this.GetComponentInParent<Button>();
        button.enabled = true;
        print(button.name);
        button.onClick.AddListener(delegate
        {
            OnButtonPress();
        });
    }

    void OnButtonPress()
    {
        print("button clicked");
        SceneManager.LoadScene(nextScene);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(nextScene));
        this.button.enabled = false;
    }

    public static WaitUntil Until(Func<bool> predicate)
    {
        return new WaitUntil(predicate);
    }

}
