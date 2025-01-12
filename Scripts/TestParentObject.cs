using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestParentObject : MonoBehaviour
{

private GameObject parentObject;
public GameObject childObject;

void Start()
{
    // Создаем родительский объект
    parentObject = new GameObject("ParentObject");
    parentObject.transform.position = Vector3.zero;

    // Создаем дочерний объект и устанавливаем его родителем
    GameObject child = Instantiate(childObject, parentObject.transform);
}

}
