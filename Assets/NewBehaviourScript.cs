using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ABTest.Instance.mainBundleName = "LessonOne"; // 设置主包的名字
        GameObject  a=ABTest.Instance.LoadRes<GameObject>("one", "GameObject"); // 直接加载LessonOne包下的Cube资源
        Instantiate(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
