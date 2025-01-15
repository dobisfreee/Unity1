using System.Collections;
using System.Collections.Generic; // collections이 기존의 STL(Standard Template Library: 여러 자료 구조, 함수, 알고리즘을 담고 있음)
                                  // 을 대체한다고 보면 된다. 
                                  // 템플릿 <-> Generic: 일반화 프로그래밍 - 컴파일이 두 번 발생한다. 
using UnityEngine;

public class Sphere: MonoBehaviour
{
    private float weight;

    public float radius = 15;
    // C#에서 컴파일 한번, IL 언어로 한 번 더 컴파일(JIT(just in time)) 되어.dll(dynamic library link) 파일이 생성되기 때문에,
    // 멀티플랫폼이 가능하다. 그래서 변수의 값을 수정하려면 c# 스크립트가 아닌 유니티에서 수정해야 한다. c#에서 후에 수정된 값을 넣고 싶으면
    // 스크립트 컴포넌트를 아예 삭제 후 다시 등록해줘야 한다. 

    private void Awake()
    {
        // Awake 함수란?
        // 게임 오브젝트가 생성되는 시점에 단 한 번만 호출되며, 스크립트가 비활성화된 상태일 때도 호출되는 이벤트 함수입니다.  
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable 함수란?
        // 게임 오브젝트가 활성화되는 시점에 호출되는 이벤트 함수입니다. 

        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // Start 함수란?
        // 게임 오브젝트가 생성되는 시점에 단 한번만 호출되며, 스크립트가 비활성화된 상태일 때는 호출되지 않는 이벤트 함수입니다. 

        Debug.Log("Start");
    }
    private void FixedUpdate()
    {
        // FixedUpdate 함수란?
        // TimeStep에 설정된 값(default: 0.02초)에 따라 일정한 간격으로 호출되는 이벤트 함수입니다. 
        // 프레임율은 불안정하기 때문에 고정된 주기에 따라 호출되어야 하는 이동 로직에 보통 쓰인다. 

        Debug.Log("FixedUpdate"); 
    }

    private void Update()
    {
        // Update 함수란?
        // 매 프레임마다 호출되며, 기기의 성능에 따라 Framerate가 바뀔 수 있는 이벤트 함수입니다. 
        // 보통 섬세하게 인지해야 하는 키 입력에 자주 사용된다. 

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate 함수란?
        // Update 함수가 호출되고 그 다음으로 매 프레임마다 호출되는 이벤트 함수입니다.
        // 보통 캐릭터가 움직인 후 카메라가 따라다니게 할 때 쓰인다. 

        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        // OnDisable 함수란?
        // 게임 오브젝트가 비활성화되었을 때 호출되는 이벤트 함수입니다. 

        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestroy 함수란?
        // 게임 오브젝트가 삭제되었을 때 호출되는 이벤트 함수입니다. 또한, 굳이 게임 오브젝트를 delete 시키지 않아도
        // 게임이 종료되어 메모리에서 해제되었을 때에도 호출된다. 

        Debug.Log("Destroy");
    }
}
