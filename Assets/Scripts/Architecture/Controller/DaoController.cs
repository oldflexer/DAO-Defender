using UnityEngine;
using UnityEngine.Serialization;

namespace Architecture.Controller
{
    public class DaoController : DaoElement
    {
        public MenuController menuController;
        public LevelsController levelsController;
        public SettingsController settingsController;

        public static void OnNotification(string pEventPath, Object pTarget, params object[] pData)
        {
            switch (pEventPath)
            {
                case DaoNotification.LevelComplete:
                    Debug.Log("Congratulations");
                    break;
            
                case DaoNotification.LevelStart:
                    Debug.Log("Level started");
                    break;
            
                case DaoNotification.ViewLoad:
                    Debug.Log("Scene loaded");
                    break;
                
                case DaoNotification.ButtonClick:
                    Debug.Log("button click");
                    break;
            
                case DaoNotification.ButtonEnterHover:
                    Debug.Log("button hover enter");
                    break;
            
                case DaoNotification.ButtonExitHover:
                    Debug.Log("button hover exit");
                    break;
            }
        }
    }
}
