using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    private GameObject clone;
    [SerializeField] GameObject unit;
    // 포인터 변수로 unit의 위치값을 0,0,-5 로 이동시키자 

    void Start()
    {
       clone = Instantiate(unit);

       clone.transform.position = new Vector3(0, 0, -5);
    }

   
}
