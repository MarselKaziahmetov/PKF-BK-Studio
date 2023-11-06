using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ListElementsStorage : MonoBehaviour
{
    [SerializeField] private GameObject listElementPrefab;

    [HideInInspector] public List<ListElementEntity> elementsList = new List<ListElementEntity>();

    public void CreateListElement(ObjectEntity objectEntity)
    {
        GameObject newElement = Instantiate(listElementPrefab, transform);
        ListElementEntity elementEntity = newElement.GetComponent<ListElementEntity>();
        elementEntity.linkedEntity = objectEntity;
        
        elementsList.Add(elementEntity);
    }
}
