using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    // 클릭하면 작아지고, 갖다대면 커지고, 밖으로 벗어나면 원래대로
    [SerializeField] Text titleText;
    public void OnEnter()
    {
        titleText.fontSize = 80;
    }

    public void OnDown()
    {
        titleText.fontSize = 50;
    }

    public void OnExit()
    {
        titleText.fontSize = 65;
    }
}
