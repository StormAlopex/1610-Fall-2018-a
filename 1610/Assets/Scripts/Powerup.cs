using UnityEngine;

[CreateAssetMenu]
public class ValueChange : ScriptableObject {

    public FloatData Data;

    public void AddValue(FloatData data)
    {
        data.Value += Data.Value;        
    }

   //-

    //*

    ///
}
