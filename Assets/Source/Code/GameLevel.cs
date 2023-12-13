using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : MonoBehaviour
{
    public List<GameObject> listSlot;
    [SerializeField] private Transform parentListObjSlot;
    
    public List<GameObject> listPlayer;
    [SerializeField] private Transform parentListPlayer;
    private bool canCheck = true;
    public void Start()
    {
        canCheck = true;
        
        foreach (Transform tr in parentListObjSlot)
        {
            listSlot.Add(tr.gameObject);
        }
        foreach (Transform tr in parentListPlayer)
        {
            listPlayer.Add(tr.gameObject);
        }
    }

    public void RemoveObject(GameObject obj)
    {
        listSlot.Remove(obj);
        if (listSlot.Count == 0)
        {
            GameManager.Instance.CheckLevelUp();
            canCheck = false;
        }
    }
    public void RemovePlayer(GameObject obj)
    {
        listPlayer.Remove(obj);
    }
}
