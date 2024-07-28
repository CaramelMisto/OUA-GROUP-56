using GameManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;
    [SerializeField] GameObject player3;
    [SerializeField] GameObject player4;

    private void Awake()
    {
        GameObject instantiatedCharacter = null;

        switch (Savings.savedObject.selectedChar)
        {
            case 0:
                instantiatedCharacter = Instantiate(player1, new Vector3(0,0.5f,4), Quaternion.identity);
                break;
            case 1:
                instantiatedCharacter = Instantiate(player2, new Vector3(0, 0.5f, 4), Quaternion.identity);
                break;
            case 2:
                instantiatedCharacter = Instantiate(player3, new Vector3(0, 0.5f, 4), Quaternion.identity);
                break;
            case 3:
                instantiatedCharacter = Instantiate(player4, new Vector3(0, 0.5f, 4), Quaternion.identity);
                break;

            default: instantiatedCharacter = Instantiate(player1, new Vector3(0, 0.5f, 4), Quaternion.identity);
                break;
        }

    }
}
