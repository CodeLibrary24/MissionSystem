using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MissionSystemEditor : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    private VisualElement _container;
    private VisualElement _root;

    [MenuItem("CodeLibrary24/Mission System")]
    public static void ShowExample()
    {
        MissionSystemEditor wnd = GetWindow<MissionSystemEditor>();
        wnd.titleContent = new GUIContent("MissionSystemEditor");
    }

    public void CreateGUI()
    {
        _root = rootVisualElement;

        _container = m_VisualTreeAsset.Instantiate();
        _root.Add(_container);
    }
}