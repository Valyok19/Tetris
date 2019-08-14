using System;
using UnityEngine;
using strange.extensions.command.impl;

public class MainContext : SignalContext
{ 
    public MainContext(MonoBehaviour view)
        : base(view)
    {

    }

    protected override void mapBindings()
    {
        base.mapBindings();

        commandBinder.Bind<GameInitiateSignal>().To<GameInitiateCommand>().Once();
    }
}
