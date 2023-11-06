using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���������� ������� � �������� ������
/// </summary>
public class ObjectsRecordController : MonoBehaviour
{
    [SerializeField] private ObjectsStorage objectsStorage;
    [SerializeField] private ListElementsStorage listElementsStorage;

    private void Start()
    {
        foreach(ObjectEntity objectEntity in objectsStorage.objectsList)
        {
            listElementsStorage.CreateListElement(objectEntity);
        }
    }
}
