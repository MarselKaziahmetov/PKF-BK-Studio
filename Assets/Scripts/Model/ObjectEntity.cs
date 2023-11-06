using UnityEngine;
using static Enums;

/// <summary>
/// Представляет сущность объекта
/// </summary>
public class ObjectEntity : MonoBehaviour
{
    [SerializeField] private ObjectColor objectColor;
    
    private string ObjectName;

    private Material objectMaterial;

    private void Awake()
    {
        ObjectName = gameObject.name;

        objectMaterial = GetComponent<Renderer>().material;
        ChangeColor(objectColor);
    }

    /// <summary>
    /// Возвращает значение прозрачности объекта
    /// </summary>
    /// <returns></returns>
    public float GetTransparencyValue()
    {
        return objectMaterial.color.a;
    }

    /// <summary>
    /// Возвращает цвет объекта
    /// </summary>
    /// <returns></returns>
    public ObjectColor GetColor()
    {
        return objectColor;
    }

    /// <summary>
    /// Возвращает имя объекта
    /// </summary>
    /// <returns></returns>
    public string GetName()
    {
        return ObjectName;
    }

    /// <summary>
    /// Менят прозрачность объекта
    /// </summary>
    /// <param name="transparencyValue"></param>
    public void ChangeTransparancy(float transparencyValue)
    {
        Color newColor = objectMaterial.color;
        newColor.a = transparencyValue;

        objectMaterial.color = newColor;
    }

    /// <summary>
    /// Меняет цвет объекта
    /// </summary>
    /// <param name="newColor"></param>
    public void ChangeColor(ObjectColor newColor)
    {
        objectColor = newColor;

        switch (objectColor)
        {
            case ObjectColor.Red:
                objectMaterial.color = Color.red;
                break;
            case ObjectColor.Green:
                objectMaterial.color = Color.green;
                break;
            case ObjectColor.Blue:
                objectMaterial.color = Color.blue;
                break;
            case ObjectColor.Orange:
                objectMaterial.color = Color.Lerp(Color.red, Color.yellow, 0.5f); ;
                break;
            case ObjectColor.Yellow:
                objectMaterial.color = Color.yellow;
                break;
            case ObjectColor.LightBlue:
                objectMaterial.color = Color.cyan;
                break;
            default:
                break;
        }
    }
}
