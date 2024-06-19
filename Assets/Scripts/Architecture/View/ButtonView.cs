using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Architecture.View
{
    public class ButtonView : DaoElement, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            DaoApplication.Notify(DaoNotification.ButtonEnterHover, this);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            DaoApplication.Notify(DaoNotification.ButtonExitHover, this);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            DaoApplication.Notify(DaoNotification.ButtonClick, this);
            transform.localScale += new Vector3(-0.15f, -0.15f, -0.15f);
        }
    }
}
