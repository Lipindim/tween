using UnityEditor;
using UnityEditor.UI;
using UnityEditor.UIElements;
using UnityEngine.UIElements;


[CustomEditor(typeof(CustomSlider))]
public class CustomSliderEditor : SliderEditor
{

    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();

        var changeButtonType = new PropertyField(serializedObject.FindProperty(CustomSlider.ChangeButtonType));
        var curveEase = new PropertyField(serializedObject.FindProperty(CustomSlider.CurveEase));
        var duration = new PropertyField(serializedObject.FindProperty(CustomSlider.Duration));

        var tweenLabel = new Label("Settings Tween");
        var intractableLabel = new Label("Intractable");

        root.Add(tweenLabel);
        root.Add(changeButtonType);
        root.Add(curveEase);
        root.Add(duration);

        root.Add(intractableLabel);
        root.Add(new IMGUIContainer(OnInspectorGUI));

        return root;
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUI.BeginChangeCheck();

        serializedObject.ApplyModifiedProperties();
    }
}
