using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatCanSeeIt : ScriptableObject {

    private float health;
    protected float powerlevel;
    public float energylevel;

    private void AddHealth()
    {
        health += 100;
    }

    protected void AddPower()
    {

        AddHealth();

    }

    public void AddEnergy() {


    }
}

public class ICanSeeIt : MonoBehaviour
{
    private WhatCanSeeIt newObject;

    private void Start()
    {
        newObject.energylevel = 100;
        newObject.AddEnergy();
    }

}

public class Child : WhatCanSeeIt
{
    void CallThings()
    {
        powerlevel = 200;
        energylevel = 300;
        AddPower();
        AddEnergy();
    }
}