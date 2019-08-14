using System.Collections;
using UnityEngine;
using strange.extensions.command.impl;

public class GameInitiateCommand : Command
{
    public override void Execute()
    {
        Debug.Log("Game Started");
    }
}
