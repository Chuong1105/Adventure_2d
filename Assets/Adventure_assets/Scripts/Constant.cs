using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constant : MonoBehaviour
{
    [SerializeField]
    private DataType dataType;

    private object data;

    private void Start() {
        switch (dataType) {
            case DataType.Integer:
                data = 42;
                break;
            case DataType.Float:
                data = 3.14f;
                break;
            case DataType.String:
                data = "Hello, world!";
                break;
            case DataType.Boolean:
                data = true;
                break;
        }
    }
}
public enum DataType 
{
    Integer,
    Float,
    String,
    Boolean
}