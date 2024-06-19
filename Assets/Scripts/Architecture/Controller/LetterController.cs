using System;
using System.Collections.Generic;
using System.Linq;
using Architecture.View;
using UnityEngine;
using UnityEngine.UI;

namespace Architecture.Controller
{
    public class LetterController : DaoElement
    {
        public static int _errorsAmount;
        
        public Button buttonNext;
        public GameObject notEnoughErrors;

        public void ChangeInteractivityButtonNext(bool state)
        {
            buttonNext.interactable = state;
        }
        
        public void ChangeStateNotEnoughErrors(bool state)
        {
            notEnoughErrors.SetActive(state);
        }

        public int GetErrorsAmount()
        {
            return _errorsAmount;
        }

        private void FixedUpdate()
        {
            CalculateErrors();
        }

        private void CalculateErrors()
        {
            var viewEnumerable = GetAllErrorBoxView();
            var temp = viewEnumerable.Count(controller => controller.IsChecked());

            _errorsAmount = temp;
        }

        public void ComputeErrorsColors()
        {
            var viewEnumerable = GetAllErrorBoxView();
            foreach (var view in viewEnumerable)
            {
                view.ComputeColor();
            }
        }
        
        private static IEnumerable<ErrorBoxView> GetAllErrorBoxView()
        {
            return FindObjectsByType<ErrorBoxView>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        }
    }
}
