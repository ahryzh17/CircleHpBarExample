using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour ,IPointerEnterHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("up");
    }

}
