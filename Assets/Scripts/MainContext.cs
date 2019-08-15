using System;
using UnityEngine;
using strange.extensions.command.impl;

public class MainContext : SignalContext
{
    private Camera MainCamera;
    private Background Background;

    public MainContext(MonoBehaviour view, Background background)
        : base(view)
    {
        Background = background;
    }

    protected override void mapBindings()
    {
        base.mapBindings();

        commandBinder.Bind<GameInitiateSignal>().To<GameInitiateCommand>().Once();

        MainCamera = Camera.main;
        injectionBinder.Bind<Camera>().ToValue(MainCamera);
        injectionBinder.Bind<Background>().ToValue(Background);
    }
}
