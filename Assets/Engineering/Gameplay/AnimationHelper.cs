using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationHelper : MonoBehaviour
{
    private InputAction moveAction;
        public Animator animator;

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
                animator.SetBool("IsSinging", true);
            Debug.Log("D key pressed");
        }
        
                if (Input.GetKeyUp(KeyCode.D))
        {
                animator.SetBool("IsSinging", false);
            Debug.Log("D key released");
        }


         
    }
}
