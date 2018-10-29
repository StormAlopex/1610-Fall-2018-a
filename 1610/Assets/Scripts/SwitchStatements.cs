using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatements : MonoBehaviour {

    public GameStates.States GameStates;
    public UnityEvent Starting, Loading, Playing, Ending, Dying;

    // Update is called once per frame
    void Update()
    {

        switch (GameStates)
        {

            case GameStates.States.Starting:

                print("We are starting the game.");
                break;

            case GameStates.States.Loading:

                print("We are loading the game.");
                break;


            case GameStates.States.Playing:

                print("We are playing the game.");
                break;

            case GameStates.States.Ending:

                print("We are ending the game.");
                break;

        }
    }
}

            
