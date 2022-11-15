using System.Collections;
using System.Collections.Generic;
using UnityEngine;

sealed class KeyModel : MonoBehaviour
{
    const int KEYVALUE_MAX = 2;
    private int KeyValue = 0;

    public int GetKeyValueMax { get { return KEYVALUE_MAX; } }
    public int PKeyValue { get { return KeyValue; } set { KeyValue = value; } }

}
