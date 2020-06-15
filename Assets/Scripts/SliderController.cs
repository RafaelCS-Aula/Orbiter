using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    private Slider progressSlider;

    private void Awake()
    {
        //slider = new Slider();
        progressSlider = GetComponent<Slider>();
    }

    public void ProgressSliderUpdate(int level)
    {
        Debug.Log($"value before update = {progressSlider.value}");
        progressSlider.value = level;
        Debug.Log($"value after update = {progressSlider.value}");
    }
}
