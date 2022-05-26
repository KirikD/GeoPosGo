using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenLocationNews : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GUiPanelLocation = GameObject.Find("GUiPanelLocation");
        GUiPanelLocation.GetComponent<CanvasGroup>().alpha = 0;
        GUiPanelLocation.GetComponent<CanvasGroup>().blocksRaycasts = false;
        GUiPanelLocation.GetComponent<CanvasGroup>().interactable = false;
    }
    public GameObject GUiPanelLocation;
    public int InfoIndex;
    // Update is called once per frame
    public void SetDescriptionBttPress(int IndexNum)
    {
        GUiPanelLocation.GetComponent<CanvasGroup>().alpha = 1;
        GUiPanelLocation.GetComponent<CanvasGroup>().blocksRaycasts = true;
        GUiPanelLocation.GetComponent<CanvasGroup>().interactable = true;

        for (int i = 1; i < GUiPanelLocation.transform.childCount; i++)
        { GUiPanelLocation.transform.GetChild(i).gameObject.SetActive(false); }

        IndexNum = InfoIndex;

        GUiPanelLocation.transform.GetChild(IndexNum).gameObject.SetActive(true);
        string[] PlaceName = GUiPanelLocation.transform.GetChild(IndexNum).gameObject.name.Split('#');
        GUiPanelLocation.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = PlaceName[1];
    }
}
