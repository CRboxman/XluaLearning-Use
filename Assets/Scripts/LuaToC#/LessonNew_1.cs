using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonNew_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("LuaMain");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
