using UnityEngine;

[CreateAssetMenu]
public class ValueChange : ScriptableObject {

    public FloatData Data;

    public void AddValue(FloatData data)
    {
        data.Value += Data.Value;        
    }

    public void SubValue(FloatData data){
        data.Value -= Data.Value;
    }

    public void MultiplyValue(FloatData data){
        data.Value *= Data.Value;
    }

    public void DivideValue(FloatData data){
        data.Value /= Data.Value;
    }

   
    
}
