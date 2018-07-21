using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour
{
    private PlayerController playerController;    //玩家控制器
    public GameObject role;                       //目前没用生成角色所以先在外部创建然后赋值
    // Use this for initialization
    void Start ()
    {
        playerController = Singleton<PlayerController>.Instance;

    }
	
	// Update is called once per frame
	void Update ()
    {
        //按下空格
		if(Input.GetKeyDown(KeyCode.Space))
        {
            //调用玩家控制器的Move方法
            playerController.Move(role,new Vector2(0,0));
        }
	}
}
