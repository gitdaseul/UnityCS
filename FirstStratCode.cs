using UnityEngine;
using System;

public class FirstStratCode : MonoBehaviour
{
    public partial class Start
    {
        public Start()
        {
            Input inputf = new Input();
            Debug.Log("Hello World");
            int HealthPoint = 50;
            Debug.Log(HealthPoint);
            if (HealthPoint >= 50)
            {
                HealthPoint--;
            }
            Debug.Log(HealthPoint);
            while (HealthPoint > 0)
            {
                HealthPoint--;
                Debug.Log("현제 채력" + HealthPoint);
                Delay(2000);

            }
            if (HealthPoint == 0)
            {
                Debug.Log("체력이" + HealthPoint + "이기 때문에 사망하셨습니다.");
            }
        }
        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                dateTimeNow = DateTime.Now;
            }
            return;
        }
    }

}