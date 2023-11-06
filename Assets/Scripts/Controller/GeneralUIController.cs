using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Отвечает за общие ui элементы, расположенные в Header
/// </summary>
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

    /// <summary>
    /// При нажатии на главный CheckBox
    /// </summary>
    /// <param name="isOn">состояние Toggle</param>
    private void OnGenerealCheckBoxToggled(bool isOn)
    {
        foreach (ListElementEntity element in elementsStorage.elementsList)
        {
            element.SwitchCheckBoxToggle(isOn);
        }
    }

    /// <summary>
    /// При нажатии на главный Visibility
    /// </summary>
    /// <param name="isOn"></param>
    private void OnGenerealVisibilityToggled(bool isOn)
    {
        foreach (ListElementEntity element in elementsStorage.elementsList)
        {
            element.SwitchVisibilityToggle(isOn);
        }
    }

    /// <summary>
    /// При изменении значения в Slider прозрачности
    /// </summary>
    /// <param name="value"></param>
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
