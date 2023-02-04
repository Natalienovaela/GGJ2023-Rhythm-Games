using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationHelper : MonoBehaviour
{
    private InputAction moveAction;
    public Animator animator;
    public KeyCode keyToSing;

    
    private void Update()
    {
        if (Input.GetKeyDown(keyToSing))
        {
                animator.SetBool("IsSinging", true);
            Debug.Log("D key pressed");
        }
        
        if (Input.GetKeyUp(keyToSing))
        {
                animator.SetBool("IsSinging", false);
            Debug.Log("D key released");
        }
         
    }
}
