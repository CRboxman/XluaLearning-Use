using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_three : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ab����������������/����
        ABTest.Instance.mainBundleName = "PC"; // ��������������   
        //��ʼ��lua��������������Զ����Lua�ض��������
        LuaMgr.GetInstance().Init();
        //ִ�д��ab����Lua�ļ�                                     ---------ab���ض������       ����txt��׺����������+����lua��������ʼ�İ�����
        //Ҳ��ִ�з����Լ����õ�asset·���µ�lua�ļ�---------------�Զ���·���ض������        ����lua��������ʼ�ĵ�ַ��
        LuaMgr.GetInstance().DoLuaFile("LuaMain");
        //��
        int i=LuaMgr.GetInstance().Global.Get<int>("a");
        print(i);
        //��
        LuaMgr.GetInstance().Global.Set("a", "AAA"); // ����ȫ�ֱ���
        //�ú���
        string iw = LuaMgr.GetInstance().Global.Get<string>("a");
        print(iw);




        //���Ҫ�������������������²���
        //ABTest.Instance.RemoveRes("���AB��������"); // �Ƴ����ص���Դ�������������ѡһ������
        //ABTest.Instance.RemoveAllRes(); // �Ƴ����м��ص���Դ�������������ѡһ��
        //ABTest.Instance.mainBundleName = "PC"; // ��������������   
        //LuaMgr.GetInstance().Init();
        //LuaMgr.GetInstance().DoLuaFile("LuaMain");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
