using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

[System.Serializable]
public class EventData
{
    public float time;
    public string noteType;
    public string noteKey;
}

public class GameManager : MonoBehaviour
{
    public TextAsset beatMap; // JSON file reference
    private EventData[] events; // Array of EventData objects

    private float startTime;

    private void Start()
    {
        // Read JSON file
        string jsonData = beatMap.text;
        events = JsonConvert.DeserializeObject<EventData[]>(jsonData);

        startTime = Time.time;
    }

    private void Update()
    {
        // Loop through events array and print messages based on time
        foreach (EventData ev in events)
        {
            if (Time.time - startTime >= ev.time)
            {
                Debug.Log(ev.noteType);
                Debug.Log(ev.noteKey);
            }
        }
    }
}
