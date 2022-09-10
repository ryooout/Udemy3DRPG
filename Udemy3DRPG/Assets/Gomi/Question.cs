using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Question : MonoBehaviour
{
    /*int n = 10;
    int m = 2;
    void Start()
    {
        Debug.Log(n !=m);
    }*/

    //int n = 1000;

    /* void Start()
     {
         while (n <= 2000)
         {
             Debug.Log(n);
         }
         while(n%273==0)
         {
             break;
         }
         n++;
     }*/




    //List/////////////////////////////
    /* void Start()
     {
         //宣言
         List<int> numberList = new List<int>();//宣言
         List<int> nList = new List<int>() { 10, 2, 3, 4, -5 };//初期化
         List<string> nameList = new List<string>() { "たかし", "川村" };

         //取得
         //Debug.Log(nList[3]);
         //代入
         nList[0] = -100;
       //  Debug.Log(nList[0]);
         //Debug.Log(numberList.Count);
         //Debug.Log(nList.Count);
         //Debug.Log(nameList.Count);
         for(var i = 0;i<nList.Count;i++)
         {
             Debug.Log("Before:" + nList[i]);
         }
         //追加後
         nList.Add(10);
         for (int i = 0; i < nList.Count; i++)
         {
             Debug.Log(nList[i]);
         }
         //1番目を削除(標準でいうと2番めを削除)
         nList.RemoveAt(1);
         for (int i = 0; i < nList.Count; i++)
         {
             Debug.Log(nList[i]);
         }
     }*/

    /* private void Start()
     {
         //関数の使い方
         //関数名（）
         // SayName();
         // SayName1("大好き",10);
         //SayName1("嫌い",20);
         string studioName = GetSayName("うんこ",3);
         Debug.Log(studioName);
     }
     //関数の作り方

     //何も返さないならVoid/String型を返すのでString　関数名（）
     string GetSayName(string UserName,int age)
     {
         Debug.Log("ボブ");//関数の処理
         return "ボブ" + UserName + age + "周年"; 
     }
     //引数のある関数の作成
     void SayName1(string userName,int age)
     {
         Debug.Log("ボブ" + userName + age);//関数の処理
         Debug.Log(userName + "ボブ" + age);
     }*/

    /*int x = 10;
    int y = 2;
    int z = -3;

    void Start()
    {
        Sample1(x, y);//10+2
        Sample1(y, z);//2-3
        Sample1(z, x);//-3+10

    }

    void Sample1(int a,int b)
    {
        Debug.Log(a + b);

    }*/

    /*
        void Start()
        {
            Move(0, 19);  // 上
            Move(0, -1);  // 下
            Move(20, 0);  // 右
            Move(-20, 0); // 左
            Move(0, 0);   // 停止
            Move(-1, -1);   // その他
        }

        void Move(int x, int y)
        {
            if (x == 0 && y > 0)
            {
                Debug.Log("上");
            }
            else if (x == 0 && y < 0)
            {
                Debug.Log("下");
            }
            else if (x > 0 && y == 0)
            {
                Debug.Log("右");
            }
            else if (x < 0 && y == 0)
            {
                Debug.Log("左");
            }
            else if(x ==0&&y==0)
            {
                Debug.Log("停止");
            }
            else
            {
                Debug.Log("その他");
            }
             */


    /*void Start()
    {
        int sum = 0;
        sum+=Damage("しまづ", 100);
        sum+=Damage("しまづ", 20);

        // sum = 100+20; //100とか20が変わるたびに修正しないといけないのでミスが起こりやすい
        Debug.Log("合計のダメージは" + sum + "です");
    }

    int Damage(string target, int damage)
    {
        Debug.Log(target + "は" + damage + "をうけました。");
        return damage;
    }*/
    /*
    int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int[] numbers2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    void Start()
    {
        ShowArrayValueLog(numbers1);
        ShowArrayValueLog(numbers2);
    }

    void ShowArrayValueLog(int[]numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
    */
    /*
    int[] numbers1 = { 2, 4, 6 };
    int[] numbers2 = { 1, 2, 3 };

    void Start()
    {
        Debug.Log(Mean(numbers1));
        Debug.Log(Mean(numbers2));
    }

    int Mean(int[] numbers)
    {
        int sum = 0;
        int count = numbers.Length;//それぞれのnumbersの長さ
        for (int i = 0; i < count; i++)
        {
            sum += numbers[i];//numberの配列を足している
        }
        return sum / count;
    }
    */
    public Player player;

    void Start()
    {
        int hp = player.hp;
        Debug.Log(hp);
    }
}





