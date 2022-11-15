using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class KeyInput : MonoBehaviour
{
    public KeyCode Key;
    private void Awake()
    {
        transform.localScale = Vector3.zero;

        Observable.EveryUpdate()
            .Where(x => Input.GetKeyDown(Key))
            .Subscribe(x => transform.localScale = Vector3.one * 2);

        Observable.EveryUpdate()
            .Where(x => Input.GetKeyUp(Key))
            .Subscribe(x => transform.localScale = Vector3.zero);
    }
}
