using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ABTest.Instance.mainBundleName = "LessonOne"; // ��������������
        GameObject  a=ABTest.Instance.LoadRes<GameObject>("one", "GameObject"); // ֱ�Ӽ���LessonOne���µ�Cube��Դ
        Instantiate(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
