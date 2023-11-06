using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralUIController : MonoBehaviour
{
    [SerializeField] private Toggle generalCheckBoxToggle;
    [SerializeField] private Toggle generalVisibilityToggle;
    [SerializeField] private Slider opacitySlider;

    [SerializeField] private ListElementsStorage elementsStorage;

    private void Awake()
    {
        generalCheckBoxToggle.onValueChanged.AddListener(OnGenerealCheckBoxToggled);
        generalVisibilityToggle.onValueChanged.AddListener(OnGenerealVisibilityToggled);
        opacitySlider.onValueChanged.AddListener(OnOpacitySliderChanged);
    }

    private void OnGenerealCheckBoxToggled(bool isOn)
    {
        foreach (ListElementEntity element in elementsStorage.elementsList)
        {
            element.SwitchCheckBoxToggle(isOn);
        }
    }

    private void OnGenerealVisibilityToggled(bool isOn)
    {
        foreach (ListElementEntity element in elementsStorage.elementsList)
        {
            element.SwitchVisibilityToggle(isOn);
        }
    }

    private void OnOpacitySliderChanged(float value)
    {
        foreach (ListElementEntity element in elementsStorage.elementsList)
        {
            if (element.GetCheckBoxState())
            {
                element.linkedEntity.ChangeTransparancy(value);
            }
        }
    }


}
