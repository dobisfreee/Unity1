using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    private GameObject clone;
    [SerializeField] GameObject unit;
    // ������ ������ unit�� ��ġ���� 0,0,-5 �� �̵���Ű�� 

    void Start()
    {
       clone = Instantiate(unit);

       clone.transform.position = new Vector3(0, 0, -5);
    }

   
}
