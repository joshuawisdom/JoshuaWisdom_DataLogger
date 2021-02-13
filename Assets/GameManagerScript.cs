using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Globalization;

public class GameManagerScript : MonoBehaviour
{
    public string filepath = "log.txt";

    public void ClickMessage()
    {
        DateTime localDate = DateTime.Now;
        Debug.Log("I was clicked at " + localDate);
    }

    // Start is called before the first frame update
    void Start()
    {
        ApplicationLoad();
        CreateFile();
        WriteFile();
    }

    // Update is called once per frame
     void Update()
    {
        DateTime localDate = DateTime.Now;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed at " + localDate);
        }
    }

     private void ApplicationLoad()
    {
        DateTime localDate = DateTime.Now;
        Debug.Log("Application loaded at " + localDate);
    }

    private void CreateFile()
    {
        if (!File.Exists(filepath))
        {
            File.Create(filepath).Close();
        }
    }

    private void WriteFile()
    {
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            writer.WriteLine("I created a file!");
        }
    }

    private void OnApplicationQuit()
    {
        DateTime localDate = DateTime.Now;
        Debug.Log("Application quit at " + localDate);
    }
}
