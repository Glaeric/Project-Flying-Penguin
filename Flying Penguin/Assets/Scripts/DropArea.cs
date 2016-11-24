using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;

        CardDragger d = eventData.pointerDrag.GetComponent<CardDragger>();
        if (d != null)
        {
            d.placeholderParent = this.transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;

        CardDragger d = eventData.pointerDrag.GetComponent<CardDragger>();
        if (d != null && d.placeholderParent == this.transform)
        {
            d.placeholderParent = d.parentToReturnTo;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        CardDragger d = eventData.pointerDrag.GetComponent<CardDragger>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }
    }

}
