using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Picking : MonoBehaviour
{
    private Ray ray; // 광선
    private RaycastHit rayCastHit; // 광선과 충돌한 오브젝트에 대한 정보를 담아준다. 

    private void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
           ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out rayCastHit, Mathf.Infinity)) //출력 매개변수 : call by ref랑 비슷하지만 변수 초기화 할 필요 X
            {
                rayCastHit.transform.GetComponent<View>().Show();

                
            }


        }

      
    }
    
}
