using System.Collections.Generic;
using Architecture.Controller;
using Architecture.Model;
using Architecture.View;
using UnityEngine;

namespace Architecture
{
    public class DaoElement : MonoBehaviour
    {
        protected static DaoApplication App => FindObjectOfType<DaoApplication>();
    }

    public class DaoApplication : MonoBehaviour
    {
        public DaoModel model;
        public DaoView view;
        public DaoController controller;
    
        public static void Notify(string pEventPath, Object pTarget, params object[] pData)
        {
            /*
            var controllerList = GetAllControllers();
            foreach(var controller in controllerList)
            {
                DaoController.OnNotification(pEventPath,pTarget,pData);
            }
            */
            DaoController.OnNotification(pEventPath,pTarget,pData);
        }

        private static IEnumerable<DaoController> GetAllControllers()
        {
            return FindObjectsByType<DaoController>(FindObjectsSortMode.None);
        }
    }
}