using UnityEngine;

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

    public void OnGazeEnter()
    {
        isGazing = true;
        Debug.Log("Gaze entered!");
    }

    public void OnGazeExit()
    {
        isGazing = false;
        Debug.Log("Gaze exited!");
    }

    public void PlayAnimation()
    {
        if (animator != null)
        {
            Debug.Log("Playing animation!");
            animator.SetTrigger("PlayAnimation");
        }
    }
}
