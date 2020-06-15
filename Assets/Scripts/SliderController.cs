using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SliderController : MonoBehaviour
{
    private Slider progressSlider;

    private void Awake()
    {
        //slider = new Slider();
        progressSlider = new Slider().GetFirstOfType<Slider>();
    }

    public void ProgressSliderUpdate(int level)
    {
        Debug.Log($"value before update = {progressSlider.value}");
        progressSlider.value = level;
        Debug.Log($"value after update = {progressSlider.value}");
    }
}
