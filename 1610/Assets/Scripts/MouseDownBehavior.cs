using UnityEngine;
using UnityEngine.Events;

public class MouseDownBehavior : MonoBehaviour {

    public UnityEvent MouseDown;
   

    private void OnMouseDown()
    {
        MouseDown.Invoke();
    }
}
