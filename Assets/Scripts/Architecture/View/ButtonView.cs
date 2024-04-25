using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Architecture.View
{
    public class ButtonView : DaoElement, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        public Button button;
        public Color wantedColor;
        private ColorBlock _colorBlock;
        private Color _originalColor;
        
        private void Start()
        {
            _colorBlock = button.colors;
            _originalColor = _colorBlock.selectedColor;
        }

        public void FixedUpdate()
        {
            button.colors = _colorBlock;
        }

        private void EnterHover()
        {
            _colorBlock.selectedColor = wantedColor;
            DaoApplication.Notify(DaoNotification.ButtonEnterHover, this);
        }

        private void ExitHover()
        {
            _colorBlock.selectedColor = _originalColor;
            DaoApplication.Notify(DaoNotification.ButtonExitHover, this);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            EnterHover();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            ExitHover();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            DaoApplication.Notify(DaoNotification.ButtonClick, this);
        }
    }
}
