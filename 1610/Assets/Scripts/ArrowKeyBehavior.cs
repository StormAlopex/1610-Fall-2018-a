
using UnityEngine;
using UnityEngine.Events;

public class ArrowKeyBehavior : MonoBehaviour {

    public UnityEvent LeftArrow;
    public UnityEvent RightArrow;
    public UnityEvent UpArrow;
    public UnityEvent DownArrow;

    public bool LeftArrowPress = false;

    public void Update(){
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            LeftArrowPress = true;
        }
    

    }

}

