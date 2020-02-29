using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectedUI : MonoBehaviour
{
    public SelectedHero instanceSelector;
    public List<Hero> UsableHeros = new List<Hero>();
    public List<Hero> UnsableHeros = new List<Hero>();//Kapalı Herolar Burda Olacak
    public List<Button> BList = new List<Button>();
    public Button battleButon;
    public GameObject pnl;
    public GameObject selectPanel;


   // public Hero hh;
    //
    void Start()
    {
        Button btn = battleButon.GetComponent<Button>();

        foreach (Button el in BList)
        {
          int  idx = BList.IndexOf(el);
            Button CloseButton = el.transform.GetChild(0).GetComponentInChildren(typeof(Button)) as Button;
            CloseButton.gameObject.SetActive(false);
            
            el.onClick.AddListener(
                delegate 
                {
                    SelectHero(el);

                    OnCloseButton(CloseButton);

                    instanceSelector.SelectHero(UsableHeros[idx]);
              
                    if (instanceSelector.TeamCount<1)
                    {
                        closeSelectable();
                        btn.gameObject.SetActive(true);
                    }
                }
            );
         
            CloseButton.onClick.AddListener(
                delegate {
                    UnSelectHero(el);
                    OffCloseButton(CloseButton);
                    instanceSelector.UnSelectHero(UsableHeros[idx]);
                    if (instanceSelector.TeamCount <3)
                    {
                        btn.gameObject.SetActive(false);
                        openSelectable();
                        
                    }
                }
            );
        }

        btn.onClick.AddListener(
            delegate
            {
                    pnl.gameObject.SetActive(true);
                    selectPanel.gameObject.SetActive(false);

            }
        );
    }

    public void closeSelectable() 
    {
        foreach (Button el in BList)
        {
            
            el.interactable = false;
        }
    }
    public void openSelectable()
    {
        foreach (Button el in BList)
        {
            Button CloseButton = el.transform.GetChild(0).GetComponentInChildren(typeof(Button)) as Button;
            if (CloseButton.gameObject.activeInHierarchy == false)
            {
                el.interactable = true;
            }
        }
    }

    public void SelectHero(Button b)
    {
        b.interactable = false;   
    }
    public void OnCloseButton(Button b) 
    {
        b.gameObject.SetActive(true);
    }

    public void UnSelectHero(Button b)
    {
        b.interactable = true;
    }
    public void OffCloseButton(Button b)
    {
        b.gameObject.SetActive(false);
    }
}
