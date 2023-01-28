using CodeLibrary24.EditorUtilities;
using UnityEditor;

namespace CodeLibrary24.MissionSystem.Editor
{
    [CustomEditor(typeof(Mission))]
    public class MissionCustomEditor : CustomEditorInspector
    {
        protected override string UxmlPath => EditorPaths.MissionCustomEditorPath;

        protected override void DrawEditor()
        {
        }
       
    }
}