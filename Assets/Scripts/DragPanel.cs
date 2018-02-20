using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public delegate void StandardDelegate(); //Toda función que tenga void sin parámetros de entrada se considerará delegate con esto.

public class DragPanel : MonoBehaviour, IPointerDownHandler, IDragHandler
{

    event StandardDelegate OnMoveEvent;

    private Vector2 pointerOffset;
    private RectTransform canvasRectTransform;
    private RectTransform panelRectTransform;

    void Awake()
    {
        Canvas canvas = GetComponentInParent<Canvas>();
        if (canvas != null)
        {
            canvasRectTransform = canvas.transform as RectTransform;
            panelRectTransform = transform.parent as RectTransform;
        }
    }

    public void OnPointerDown(PointerEventData data)
    {
        panelRectTransform.SetAsLastSibling();
        RectTransformUtility.ScreenPointToLocalPointInRectangle(panelRectTransform, data.position, data.pressEventCamera, out pointerOffset);
    }

    public void OnDrag(PointerEventData data)
    {
        if (panelRectTransform == null)
            return;

        Vector2 pointerPostion = ClampToWindow(data);

        Vector2 localPointerPosition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvasRectTransform, pointerPostion, data.pressEventCamera, out localPointerPosition
        ))
        {
            panelRectTransform.localPosition = localPointerPosition - pointerOffset;

            if (OnMoveEvent != null)
                OnMoveEvent();
        }
    }

    Vector2 ClampToWindow(PointerEventData data)
    {
        Vector2 rawPointerPosition = data.position;

        Vector3[] canvasCorners = new Vector3[4];
        canvasRectTransform.GetWorldCorners(canvasCorners);

        float clampedX = Mathf.Clamp(rawPointerPosition.x, canvasCorners[0].x, canvasCorners[2].x);
        float clampedY = Mathf.Clamp(rawPointerPosition.y, canvasCorners[0].y, canvasCorners[2].y);

        Vector2 newPointerPosition = new Vector2(clampedX, clampedY);
        return newPointerPosition;
    }

    public void RegisterOnMoveEvent(StandardDelegate callback)
    {
        OnMoveEvent += callback;
    }

    public void UnregisterOnMoveEvent(StandardDelegate callback)
    {
        OnMoveEvent -= callback;
    }
}