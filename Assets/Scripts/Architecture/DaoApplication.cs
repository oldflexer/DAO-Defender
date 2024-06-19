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
        public static void Notify(string pEventPath, Object pTarget, params object[] pData)
        {
            DaoController.OnNotification(pEventPath, pTarget, pData);
        }
    }
}