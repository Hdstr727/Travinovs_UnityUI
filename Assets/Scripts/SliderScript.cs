using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

    public GameObject HeightSlider;
    public GameObject WidthSlider;
    public GameObject Character;

    public void ChangeHeight()
    {
        float currentHeight = HeightSlider.GetComponent<Slider>().value;
        float currentWidth = WidthSlider.GetComponent<Slider>().value;
        Character.transform.localScale = new Vector2(1f * currentWidth, 1f * currentHeight);
    }

    public void ChangeWidth()
    {
        float currentWidth = WidthSlider.GetComponent<Slider>().value;
        float currentHeight = HeightSlider.GetComponent<Slider>().value;
        Character.transform.localScale = new Vector2(1f * currentWidth, 1f * currentHeight);
    }
}
