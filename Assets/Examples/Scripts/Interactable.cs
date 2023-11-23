using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Liminal.Examples
{
    /// <summary>
    /// Just by implementing IPointerClickHandler like any UI, you can click on objects
    /// </summary>
    public class Interactable : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
    {
        public UnityEvent OnClick;

        public UnityEvent OnSelect;

        public UnityEvent OnDeselect;

        public void OnPointerClick(PointerEventData eventData)
        {
            OnClick.Invoke();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            OnSelect.Invoke();
            Debug.Log("entered");
        }        
        public void OnPointerExit(PointerEventData eventData)
        {
            OnDeselect.Invoke();
            Debug.Log("exited");
        }
    }
}
