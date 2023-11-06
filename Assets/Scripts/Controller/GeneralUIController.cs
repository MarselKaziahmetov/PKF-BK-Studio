using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �������� �� ����� ui ��������, ������������� � Header
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
    /// ��� ������� �� ������� CheckBox
    /// </summary>
    /// <param name="isOn">��������� Toggle</param>
    private void OnGenerealCheckBoxToggled(bool isOn)
    {
        foreach (ListElementEntity element in elementsStorage.elementsList)
        {
            element.SwitchCheckBoxToggle(isOn);
        }
    }

    /// <summary>
    /// ��� ������� �� ������� Visibility
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
    /// ��� ��������� �������� � Slider ������������
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
