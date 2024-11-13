using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class OpenScener : EditorWindow
{
    private static string _scenePath = "Assets/HauntedHouse/Scenes/{0}.unity";

    [MenuItem("OpenScene/MainMenu", false, 0)]
    public static void MainMenu()
    {
        EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
        EditorSceneManager.OpenScene
           (string.Format(_scenePath, "MainMenu"), OpenSceneMode.Single);
    }
}
