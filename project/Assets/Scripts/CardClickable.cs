using Unity.VisualScripting;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class CardClickable : BasicClickable
{
    public string CardName;
    private void OnMouseDown()
    {
        if (GameObject.FindAnyObjectByType<Dialogue_UI>().openDialogue(getMessage()))
        {
            interactCount++;
            this.GetComponentInParent<Transform>().position = new Vector3(1, -100);
            SaveFile();
            GameObject.FindAnyObjectByType<CardCounter>().increment();
        }
        
    }

    public void SaveFile()
    {
        string destination = Application.persistentDataPath + "/cardsave.txt";
        print(destination);
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);
        file.Close();

        TextWriter tw;
        tw = File.AppendText(Application.persistentDataPath + "/cardsave.txt");
        tw.WriteLine(CardName);
        tw.Close();
        //file.Close();

        
    }
}
