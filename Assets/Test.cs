using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour
{

	void Start ()
    {
        //Lesson4課題

        int[] array = { 2, 5, 3, 6, 4 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }



        //以下、Lesson4発展課題

        Boss boss = new Boss();

        for (int i = 1; i <= 10; i++)
        {
            boss.Magic();
        }

        boss.Magic();
    }
}

public class Boss
{
    int mp = 53;

    public void Magic()
    {
        this.mp -= 5;

        if (this.mp > 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}
