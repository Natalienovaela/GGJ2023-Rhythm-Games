using UnityEngine;
using UnityEngine.UI;

public class MakeSliderSelectable : MonoBehaviour
{
    void Start()
    {
        Slider slider = GetComponent<Slider>();
        slider.GetComponent<Selectable>().interactable = true;
    }
}
