using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

[System.Serializable]
public class NoteData
{
    public float time;
    public string noteType;
    public string noteKey;
}

public class GameManager : MonoBehaviour
{
    public TextAsset beatMap; // JSON file reference
    private NoteData[] notes; // Array of NoteData objects
    private int noteIndex;
    private float startTime;

    // GameObject references for D, F, G, H, J
    public Root RootD;
    public Root RootF;
    public Root RootG;
    public Root RootH;
    public Root RootJ;

    private void Start()
    {
        // Read JSON file
        string jsonData = beatMap.ToString();
        notes = JsonConvert.DeserializeObject<NoteData[]>(jsonData);

        noteIndex = 0;
        startTime = Time.time;
    }

    private void Update()
    {
        if (noteIndex >= notes.Length)
        {
            ShowGameOverScreen();
            return;
        }

        // Trigger events based on time
        if (Time.time - startTime >= notes[noteIndex].time)
        {
            Debug.Log("note is: " + notes[noteIndex].noteKey);
            Root parentRootObject = null;

            // Get reference to the game object corresponding to noteKey
            switch (notes[noteIndex].noteKey)
            {
                case "D":
                    parentRootObject = RootD;
                    break;
                case "F":
                    parentRootObject = RootF;
                    break;
                case "G":
                    parentRootObject = RootG;
                    break;
                case "H":
                    parentRootObject = RootH;
                    break;
                case "J":
                    parentRootObject = RootJ;
                    break;
            }

            if (parentRootObject != null)
            {
                parentRootObject.RunNoteFlow();
            }

            noteIndex++;
        }
    }

    // Function to show gameover screen
    private void ShowGameOverScreen()
    {
        Debug.Log("Show gameover screen");
    }

    // Function to restart game
    public void RestartGame()
    {
        Debug.Log("Restart game");
        noteIndex = 0;
        startTime = Time.time;
    }
}
