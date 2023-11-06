using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Хранит все элементы списка на панели
/// </summary>
public class ListElementsStorage : MonoBehaviour
{
    [SerializeField] private GameObject listElementPrefab;

    [HideInInspector] public List<ListElementEntity> elementsList = new List<ListElementEntity>();

    /// <summary>
    /// Создает префаб элемента списка в панели
    /// </summary>
    /// <param name="objectEntity"></param>
    public void CreateListElement(ObjectEntity objectEntity)
    {
        GameObject newElement = Instantiate(listElementPrefab, transform);
        ListElementEntity elementEntity = newElement.GetComponent<ListElementEntity>();
        elementEntity.linkedEntity = objectEntity;
        
        elementsList.Add(elementEntity);
    }
}
