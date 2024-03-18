using UnityEngine;
using UnityEngine.EventSystems;

public class Buttonbehavior : MonoBehaviour, ISelectHandler, IPointerEnterHandler, IEndDragHandler
{
    private CanvasGroup canvasGroup;
    public void OnSelect(BaseEventData eventData)
    {
        canvasGroup = transform.GetComponentInParent<CanvasGroup>();
        if (canvasGroup.interactable)
        {
        GetComponent<AudioSource>().Play();
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        canvasGroup = transform.GetComponentInParent<CanvasGroup>();
        if (canvasGroup.interactable)
        {
            EventSystem.current.SetSelectedGameObject(gameObject);
        }
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup = transform.GetComponentInParent<CanvasGroup>();
        if (canvasGroup.interactable)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
