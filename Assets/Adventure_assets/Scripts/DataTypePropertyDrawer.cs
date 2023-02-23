using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(DataType))]
public class DataTypePropertyDrawer : PropertyDrawer
{
public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) 
{
        EditorGUI.BeginProperty(position, label, property);

        // Draw the drop-down list
        property.enumValueIndex = EditorGUI.Popup(position, label.text, property.enumValueIndex, property.enumNames);

        EditorGUI.EndProperty();
}
}
