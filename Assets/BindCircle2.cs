using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


[RequireComponent(typeof(Scrollbar))]
public class BindCircle2 : MonoBehaviour
{
    [SerializeField]
    Image CircleImage;
    [SerializeField]
    Color start;
    [SerializeField]
    Color end;


    Scrollbar scrollbar { get { return GetComponent<Scrollbar>(); } }

    void Update()
    {
        CircleImage.fillAmount = scrollbar.value;
        CircleImage.color = Color.Lerp(start, end, scrollbar.value);
    }

     
}
