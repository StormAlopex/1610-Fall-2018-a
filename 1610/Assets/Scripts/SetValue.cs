using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]

public class SetValue : ScriptableObject {
    public FloatData Value;
    public FloatData MaxValue;

   

    public void setValue(FloatData value)
    {
        Value.Value = MaxValue.Value;
        
    }
}
