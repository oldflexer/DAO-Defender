using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Architecture.View
{
    public class ErrorBoxView : DaoElement
    {
        public SpriteRenderer spriteRenderer;
        public Color checkedColor = new(1, 1, 0, 0.5f);
        public Color correctColor = new(0, 1, 0, 0.5f);
        public Color incorrectColor = new(1, 0, 0, 0.5f);
        public GameObject errorExplanation;
        private bool _isChecked;
        private bool _isInteractable = true;

        public bool IsChecked()
        {
            return _isChecked;
        }

        private void Start()
        {
            spriteRenderer.color = Color.clear;
        }
        
        private void OnMouseDown()
        {
            if (!_isInteractable) return;
            
            spriteRenderer.color = spriteRenderer.color == Color.clear ? checkedColor : Color.clear;
            _isChecked = spriteRenderer.color != Color.clear;
        }

        public void ComputeColor()
        {
            if (!_isInteractable) return;
            
            if (spriteRenderer.color == checkedColor || spriteRenderer.color == correctColor)
                spriteRenderer.color = correctColor;
            else
                spriteRenderer.color = incorrectColor;
            
            errorExplanation.SetActive(true);
            
            _isInteractable = false;
        }
    }
}
