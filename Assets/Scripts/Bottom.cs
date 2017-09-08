using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour {

    public GameObject gameOver;
    bool goTitle = false;

    void Update()
    {
        if (goTitle)
        {
            //GameOverの文字が表示された状態で画面をクリック
            if (Input.GetMouseButtonDown(0))
            {
                Application.LoadLevel("title");//タイトル画面へ
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);//ボール消滅
                                //GameOverの文字を表示
        gameOver.SendMessage("Lose");
        goTitle = true;//Update文の実行
    }
}