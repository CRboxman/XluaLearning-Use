using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_three : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoString("require ('LuaMain')");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
