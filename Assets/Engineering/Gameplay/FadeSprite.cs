using UnityEngine;
using UnityEngine.UI;

public class FadeSprite : MonoBehaviour
{
    public Image sprite;
    public float fadeDuration = 0.5f;

    public void ShowSprite()
    {
        sprite.CrossFadeAlpha(1f, fadeDuration, false);
    }

    public void HideSprite()
    {
        sprite.CrossFadeAlpha(0f, fadeDuration, false);
    }
}

