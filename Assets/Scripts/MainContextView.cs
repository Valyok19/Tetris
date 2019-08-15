using strange.extensions.context.impl;
using strange.extensions.injector.api;
using strange.extensions.signal.impl;
using UnityEngine;

public class MainContextView : ContextView
{
    [SerializeField]
    private GameObject BackgroundPrefab;

    void Start()
    {
        MainContext context = new MainContext(this, BackgroundPrefab.GetComponent<Background>());
        context.Start();
    }
}
