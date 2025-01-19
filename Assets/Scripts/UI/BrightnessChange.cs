using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessChange : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] float sliderValue;
    [SerializeField] Image panelBrillo;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0.2f);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderValue);
    }

   public void ChangeSlider(float valor)
   {
        sliderValue = valor;
        PlayerPrefs.SetFloat("brilo", sliderValue);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderValue);

    }
}
