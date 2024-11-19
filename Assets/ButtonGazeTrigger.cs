using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonGazeTrigger : MonoBehaviour
{
    public Animator animator; // Assign the Animator in the Inspector
    private bool isGazing = false;

    void Update()
    {
        // Detect screen taps as input
        if (Input.GetMouseButtonDown(0) && isGazing)
        {
            PlayAnimation();
        }
    }

    // Triggered on Gaze Enter
    public void OnGazeEnter(BaseEventData eventData)
    {
        isGazing = true;
        Debug.Log("Gaze entered!");
    }

    // Triggered on Gaze Exit
    public void OnGazeExit(BaseEventData eventData)
    {
        isGazing = false;
        Debug.Log("Gaze exited!");
    }

    // Play the animation
    public void PlayAnimation()
    {
        if (animator != null)
        {
            Debug.Log("Playing animation!");
            animator.SetTrigger("PlayAnimation");
        }
    }
}
