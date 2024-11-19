using UnityEngine;

public class DebugButtonInteraction : MonoBehaviour
{
    void OnMouseOver()
    {
        Debug.Log("Button is being gazed at!");
    }

    void OnMouseDown()
    {
        Debug.Log("Button clicked or screen tapped!");
    }
}
