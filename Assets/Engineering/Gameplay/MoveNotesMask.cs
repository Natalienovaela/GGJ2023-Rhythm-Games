using UnityEngine;
using UnityEngine.Events;

public class MoveSpriteMask : MonoBehaviour
{
    [SerializeField] private Transform maskTransformA;
    [SerializeField] private Transform maskTransformB;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float tolerance = 0.1f;
    [SerializeField] private UnityEvent onMaskCloseToDestination;    [SerializeField] public Root root;
    private float startTime;
    
    public bool running = false;
    
    
    private float t;
private float startSpeed;
private float endSpeed;
private float rampUpDuration = 1.0f;

    
    private void Start(){
       t = 0;
    startSpeed = 0;
    endSpeed = speed;
    startTime = Time.time;
    }

    private void Update()
    {
    
    if(running)
    {
              float elapsedTime = Time.time - startTime;
    float currentSpeed = Mathf.Lerp(startSpeed, endSpeed, Mathf.Clamp01(elapsedTime / rampUpDuration));
    t = Mathf.Clamp01(t + currentSpeed * Time.deltaTime);
    this.transform.position = Vector3.Lerp(maskTransformA.position, maskTransformB.position, t);

        if (Vector2.Distance(this.transform.position, maskTransformB.position) < tolerance)
        {
            onMaskCloseToDestination.Invoke();
        }
    }
    
    }
    
    public void ToggleRunning(bool isRunning){
        running = isRunning;
    }
    
    public void Reset(bool resetToA)
    {
    running = false;
    if(resetToA)
    {
    Debug.Log("Debug log message from Start() method");
    this.transform.position = maskTransformA.position;
    }
    else
    {
    this.transform.position =maskTransformB.position;
    }
    }
}