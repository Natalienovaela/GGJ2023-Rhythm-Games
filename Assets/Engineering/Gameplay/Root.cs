using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Root : MonoBehaviour
{
    public MoveSpriteMask downMovementMask;
    public MoveSpriteMask upMovementMask;
        public MoveSpriteMask perfectMask;
        public MoveSpriteMask incomingMask;

    public GameObject missedBG;
        public GameObject perfectBG;
        public GameObject incomingBG;
        public GameObject baseBG;
        public KeyCode interactionKey;
        
        bool isGameplayRunning = false;
    
    public enum CompletionStatus
    {
        Normal,
        Perfect,
        Missed,
    }

    // Start is called before the first frame update
    void Start()
    {
     StartGameplay();
    }
    
    void Update()
    {
    if(isGameplayRunning)
    {
      if (Input.GetKeyDown(interactionKey))
    {
    incomingBG.SetActive(false);
        incomingMask.Reset(true);
    perfectMask.ToggleRunning(true);
    }
    }
    }
    
    void StartGameplay()
    {
    isGameplayRunning = true;
       downMovementMask.ToggleRunning(true);
    }
    
    
    public void CompleteNoteMovement(CompletionStatus completionStatus){
    

    }
    
    public void CompleteMovementForMissed()
    {

        missedBG.SetActive(true);
        upMovementMask.ToggleRunning(true);
    
    }
}
