using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetPlayerPosition : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] Transform House1;
    [SerializeField] Transform House2;
    [SerializeField] Transform House3;
    [SerializeField] Transform House4;
    [SerializeField] Transform House5;


    // Start is called before the first frame update
    void Start()
    {
        int recievedHouse = DangerZone.House;
        switch (recievedHouse)
        {
            case 1:
                rb2D.position = House1.position;
                break;
            case 2:
                rb2D.position = House2.position;
                break;
            case 3:
                rb2D.position = House3.position;
                break;
            case 4:
                rb2D.position = House4.position;
                Debug.Log(House4.position);
                break;
            case 5:
                rb2D.position = House5.position;
                Debug.Log(House5.position);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
