using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DropDownScript : MonoBehaviour
{
    TMP_Dropdown menu;
    string currentScene;
    private void Start()
    {
        menu = this.GetComponentInParent<TMP_Dropdown>();
        print(menu.name);
        menu.enabled = true;
        menu.onValueChanged.AddListener(delegate
        {
            OnDropdownValueChanged();
        } );
    }

    public void OnDropdownValueChanged() {
        string name = menu.captionText.text;
        print(name);
        SceneManager.LoadScene(name);
        
        if(SceneManager.GetSceneByName(name).isLoaded)
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
    
            if (menu != null)
            {
                Destroy(menu.gameObject);
            }
        }

        currentScene = name;
    }
}
