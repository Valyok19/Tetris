using UnityEngine;
using strange.extensions.command.impl;

public class GameInitiateCommand : Command
{
    [Inject]
    public Camera Camera { get; set; }

    [Inject]
    public Background BackgroundPrefab { get; set; }

    public override void Execute()
    {
        Spawn();
    }

    private void Spawn()
    {
        Background background = GameObject.Instantiate(BackgroundPrefab, new Vector3(0, 0, 0), Quaternion.identity);

        float cameraH;
        float cameraW;
        ScreenSizeAdapt(out cameraH, out cameraW);
        background.ToScreenSize(cameraH, cameraW);
    }

    private void ScreenSizeAdapt(out float cameraH, out float cameraW)
    {
        float screenH = Screen.height;
        float screenW = Screen.width;        

        float screenAspect = screenW / screenH;
        Camera.aspect = screenAspect;

        cameraH = Camera.orthographicSize * 100.0f * 2.0f;
        cameraW = cameraH * screenAspect;
    }
}
