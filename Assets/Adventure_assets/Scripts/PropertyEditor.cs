using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
// [CustomEditor(typeof(Property))]
// public class PropertyEditor: MonoBehaviour
// {
//     string[] choices = new[] { "class1", "class2"};
//     int choiceIndex = 0;
 
//     public override void OnInspectorGUI() 
//     {
//         base.OnInspectorGUI();
//         choiceIndex = EditorGUILayout.Popup(choiceIndex, choices);
//         var myGameObject = target as Property;
 
//         switch (choiceIndex) {
//             case 0:
//                 myGameObject.myClass = new class1();
//             case 1:
//                 myGameObject.myClass = new class2();
//             //etc...
//     }
//         EditorUtility.SetDirty(target);
 
//     }
// }