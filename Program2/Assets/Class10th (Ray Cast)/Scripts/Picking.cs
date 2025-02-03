using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Picking : MonoBehaviour
{
    private Ray ray; // ����
    private RaycastHit rayCastHit; // ������ �浹�� ������Ʈ�� ���� ������ ����ش�. 

    private void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
           ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out rayCastHit, Mathf.Infinity)) //��� �Ű����� : call by ref�� ��������� ���� �ʱ�ȭ �� �ʿ� X
            {
                rayCastHit.transform.GetComponent<View>().Show();

                
            }


        }

      
    }
    
}
