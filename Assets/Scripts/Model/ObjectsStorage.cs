using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Хранит все объекты, расположенные на сцене
/// </summary>
public class ObjectsStorage : MonoBehaviour
{
    [HideInInspector] public List<ObjectEntity> objectsList;

    private void Awake()
    {
        foreach (Transform child in transform)
        {
            // Проверяем, есть ли на дочернем объекте компонент ObjectEntity
            ObjectEntity objectChild = child.GetComponent<ObjectEntity>();
            if (objectChild != null)
            {
                // Если компонент ObjectEntity присутствует, добавляем его в список
                objectsList.Add(objectChild);
            }
        }
    }
}
