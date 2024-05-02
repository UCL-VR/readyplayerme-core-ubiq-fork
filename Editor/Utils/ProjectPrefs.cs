using UnityEditor;
using UnityEngine;

public static class ProjectPrefs
{
    // Two pref keys as the loader package sometimes uses the alt key 
    public const string FIRST_TIME_SETUP_DONE = "first-time-setup-guide";
    public const string FIRST_TIME_SETUP_DONE_ALT = "first-time-setup"; 

    public static bool GetBool(string key)
    {
        if (key == FIRST_TIME_SETUP_DONE || key == FIRST_TIME_SETUP_DONE_ALT)
        {
            return true;
        }
        return EditorPrefs.GetBool($"{Application.dataPath}{key}");
    }

    public static void SetBool(string key, bool value)
    {
        EditorPrefs.SetBool($"{Application.dataPath}{key}", value);
    }
}
