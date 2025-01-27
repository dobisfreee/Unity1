using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardBall : MonoBehaviour
{
    
    private Rigidbody rigidbody;

    [SerializeField] Vector3 direction;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
      

    }

    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction, ForceMode.Force);

        // ForceMode.Force : �������� ���� �����ϴ� ����̸�, ��ü�� ���� ��������� �����ϴ� ������� �ð��� ����Ͽ� �����մϴ�. 

        // ForceMode.Impulse : �������� ���� �����ϴ� ����̸�, ��ü�� ���ӵ��� �ƴ� �ӵ��� ��ȭ��Ű�� ����Դϴ�. 

        // ForceMode.VelocityChange: �������� ���� �����ϴ� ����̸�, ��ü�� �ӵ��� ��ȭ��Ű��, ��ü�� ���Կ��� ������ ���� �ʽ��ϴ�. 

        // Forcemode. Acceleration : �������� ���� �����ϴ� ����̸�, ��ü�� ���� ��������� �����ϴ� ���������, ��ü�� ���Կ� ������ ���� �ʽ��ϴ�.  
    }
 
    // OnCollision

    private void OnCollisionEnter(Collision collision)
    {

        IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();

        if(damageable != null)
        {
            damageable.Use();
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }
    
    private void OnCollisionExit(Collision collision)
    {
  
         Debug.Log("OnCollisionExit");
    }

    // OnTrigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal Line")
        {
            Debug.Log("OnTriggerEnter");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Goal Line")
        {

            Debug.Log("OnTriggerStay");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Goal Line")
        {

            Debug.Log("OnTriggerExit");
        }
    }
}
