using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private SpriteRenderer Sprite { get; set; }

    void Awake()
    {
        Sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    public void ToScreenSize(float cameraH, float cameraW)
    {
        float bgH = Sprite.sprite.rect.height;
        float bgW = Sprite.sprite.rect.width;

        float scaleH = cameraH / bgH;
        float scaleW = cameraW / bgW;

        Sprite.transform.localScale = new Vector3(scaleW, scaleH, 1);
    }
}
