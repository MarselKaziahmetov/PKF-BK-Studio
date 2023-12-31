using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������ ��� �������, ������������� �� �����
/// </summary>
public class ObjectsStorage : MonoBehaviour
{
    [HideInInspector] public List<ObjectEntity> objectsList;

    private void Awake()
    {
        foreach (Transform child in transform)
        {
            ObjectEntity objectChild = child.GetComponent<ObjectEntity>();
            if (objectChild != null)
            {
                objectsList.Add(objectChild);
            }
        }
    }
}
