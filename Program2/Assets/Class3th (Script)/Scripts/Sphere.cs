using System.Collections;
using System.Collections.Generic; // collections�� ������ STL(Standard Template Library: ���� �ڷ� ����, �Լ�, �˰����� ��� ����)
                                  // �� ��ü�Ѵٰ� ���� �ȴ�. 
                                  // ���ø� <-> Generic: �Ϲ�ȭ ���α׷��� - �������� �� �� �߻��Ѵ�. 
using UnityEngine;

public class Sphere: MonoBehaviour
{
    private float weight;

    public float radius = 15;
    // C#���� ������ �ѹ�, IL ���� �� �� �� ������(JIT(just in time)) �Ǿ�.dll(dynamic library link) ������ �����Ǳ� ������,
    // ��Ƽ�÷����� �����ϴ�. �׷��� ������ ���� �����Ϸ��� c# ��ũ��Ʈ�� �ƴ� ����Ƽ���� �����ؾ� �Ѵ�. c#���� �Ŀ� ������ ���� �ְ� ������
    // ��ũ��Ʈ ������Ʈ�� �ƿ� ���� �� �ٽ� �������� �Ѵ�. 

    private void Awake()
    {
        // Awake �Լ���?
        // ���� ������Ʈ�� �����Ǵ� ������ �� �� ���� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.  
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable �Լ���?
        // ���� ������Ʈ�� Ȱ��ȭ�Ǵ� ������ ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�. 

        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // Start �Լ���?
        // ���� ������Ʈ�� �����Ǵ� ������ �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ���� ȣ����� �ʴ� �̺�Ʈ �Լ��Դϴ�. 

        Debug.Log("Start");
    }
    private void FixedUpdate()
    {
        // FixedUpdate �Լ���?
        // TimeStep�� ������ ��(default: 0.02��)�� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�. 
        // ���������� �Ҿ����ϱ� ������ ������ �ֱ⿡ ���� ȣ��Ǿ�� �ϴ� �̵� ������ ���� ���δ�. 

        Debug.Log("FixedUpdate"); 
    }

    private void Update()
    {
        // Update �Լ���?
        // �� �����Ӹ��� ȣ��Ǹ�, ����� ���ɿ� ���� Framerate�� �ٲ� �� �ִ� �̺�Ʈ �Լ��Դϴ�. 
        // ���� �����ϰ� �����ؾ� �ϴ� Ű �Է¿� ���� ���ȴ�. 

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate �Լ���?
        // Update �Լ��� ȣ��ǰ� �� �������� �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        // ���� ĳ���Ͱ� ������ �� ī�޶� ����ٴϰ� �� �� ���δ�. 

        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        // OnDisable �Լ���?
        // ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�. 

        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestroy �Լ���?
        // ���� ������Ʈ�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�. ����, ���� ���� ������Ʈ�� delete ��Ű�� �ʾƵ�
        // ������ ����Ǿ� �޸𸮿��� �����Ǿ��� ������ ȣ��ȴ�. 

        Debug.Log("Destroy");
    }
}
