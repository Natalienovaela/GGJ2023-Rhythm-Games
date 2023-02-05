using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackBoard : MonoBehaviour
{
    [SerializeField] public FadeSprite GoodFadeSprite;
    [SerializeField] public FadeSprite PerfectFadeSprite;
    [SerializeField] public FadeSprite MissFadeSprite;
    
    
    void ShowGoodFadeSprite()
    {
    GoodFadeSprite.ShowSprite();
    PerfectFadeSprite.HideSprite();
    MissFadeSprite.HideSprite();
    }
    
        void ShowPerfectFadeSprite()
    {
    GoodFadeSprite.HideSprite();
    PerfectFadeSprite.ShowSprite();
    MissFadeSprite.HideSprite();
    }
    
        void ShowMissFadeSprite()
    {
    GoodFadeSprite.HideSprite();
    PerfectFadeSprite.HideSprite();
    MissFadeSprite.ShowSprite();
    }
}
