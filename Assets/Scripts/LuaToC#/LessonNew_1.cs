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
public class Lesson1 
{
    public int[] arr = new int[5] { 1,2,3,4,5};
    public List<int> list = new List<int>() { 9,8,7,6,5};
    public Dictionary<int, string> dic = new Dictionary<int, string>()
    {
        {1,"one" },
        {2,"two" },
        {3,"three" },
        {4,"four" },
        {5,"five" }
    };

}
