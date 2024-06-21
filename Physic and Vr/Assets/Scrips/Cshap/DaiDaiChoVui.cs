using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class DaiDaiChoVui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //demo lambda
        MoveGameObject(() =>
        {
            Debug.Log("Callback");
        });
        //demo multi thread1
        Debug.Log(" Start call count down");
        StartCoroutine(CountDown());
        Debug.Log(" End call count down");

        //demo multi thtread2
        MultiThread02();
    }
    private async void MultiThread02()
    {
        Debug.Log("Start multi tasks");
        List<UniTask> tasks = new List<UniTask>();
        tasks.Add(TaskA("Move Object", 2000));
        tasks.Add(TaskA("Scale Object", 4000));
        await UniTask.WhenAll(tasks);
        Debug.Log("Completed tasks");
    }
    private async UniTask TaskA(String log, int delay)
    {
        Debug.Log($"Task Start {log}");
        await UniTask.Delay(delay);
        Debug.Log($"Task Done {log}");
    }
    private IEnumerator CountDown()
    {
        Debug.Log(" Start Count down");
        int countTime = 3;
        for (int i = 0; i < countTime; i++)
        {
            yield return new WaitForSeconds(1);
        }
    }
    private void MoveGameObject(Action callback)
    {
        Debug.Log("Move Game Object completed");
        callback?.Invoke();
    }
}
