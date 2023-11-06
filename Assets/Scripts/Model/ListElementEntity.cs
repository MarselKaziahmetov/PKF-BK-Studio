using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Enums;

public class ListElementEntity : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI labelText;
    [SerializeField] private Toggle checkBoxToggle;
    [SerializeField] private Toggle visibilityToggle;
    [SerializeField] public TMP_Dropdown colorDropdown;

    [HideInInspector] public ObjectEntity linkedEntity;

    private void Start()
    {
        colorDropdown.onValueChanged.AddListener(OnColorChanged);
        visibilityToggle.onValueChanged.AddListener(SwitchVisibility);

        InitializeElementView();
    }

    public bool GetCheckBoxState()
    {
        return checkBoxToggle.isOn;
    }

    public void SwitchCheckBoxToggle(bool isOnState)
    {
        checkBoxToggle.isOn = isOnState;
    }

    public void SwitchVisibilityToggle(bool isOnState)
    {
        visibilityToggle.isOn = isOnState;
        SwitchVisibility(isOnState);
    }

    private void InitializeElementView()
    {
        DisplayElementName(linkedEntity.GetName());
        DisplayElementColor(linkedEntity.GetColor());
    }

    private void OnColorChanged(int value)
    {
        switch (value)
        {
            case 0:
                linkedEntity.ChangeColor(ObjectColor.Red);
                break;
            case 2:
                linkedEntity.ChangeColor(ObjectColor.Green);
                break;
            case 3:
                linkedEntity.ChangeColor(ObjectColor.Blue);
                break;
            case 4:
                linkedEntity.ChangeColor(ObjectColor.Orange);
                break;
            case 1:
                linkedEntity.ChangeColor(ObjectColor.Yellow);
                break;
            case 5:
                linkedEntity.ChangeColor(ObjectColor.LightBlue);
                break;
            default:
                break;
        }
    }

    private void DisplayElementName(string name)
    {
        labelText.text = name;
    }

    private void DisplayElementColor(ObjectColor color)
    {
        switch (color)
        {
            case ObjectColor.Red:
                colorDropdown.value = 0;
                break;
            case ObjectColor.Green:
                colorDropdown.value = 2;
                break;
            case ObjectColor.Blue:
                colorDropdown.value = 3;
                break;
            case ObjectColor.Orange:
                colorDropdown.value = 4;
                break;
            case ObjectColor.Yellow:
                colorDropdown.value = 1;
                break;
            case ObjectColor.LightBlue:
                colorDropdown.value = 5;
                break;
            default:
                break;
        }
    }

    private void SwitchVisibility(bool value)
    {
        if (value)
            linkedEntity.ChangeTransparancy(1);
        else
            linkedEntity.ChangeTransparancy(0);
    }
}
