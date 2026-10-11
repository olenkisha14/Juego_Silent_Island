using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHouse : MonoBehaviour
{
    [SerializeField] SpriteRenderer npc;
    [SerializeField] Sprite npc1;
    [SerializeField] Sprite npc2;
    [SerializeField] Sprite npc3;
    [SerializeField] Sprite npc4;


    // Start is called before the first frame update
    void Start()
    {
        var spr = npc1;
        int recievedHouse = DangerZone.House;
        switch (recievedHouse)
        {
            case 1:
                spr = npc1;
                print(spr);
                npc.sprite = spr;
                break;
            case 2:
                spr = npc2;
                print(spr);
                npc.sprite = spr;
                break;
            case 3:
                spr = npc3;
                print(spr);
                npc.sprite = spr;
                break;
            case 4:
                spr = npc4;
                print(spr);
                npc.sprite = spr;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}