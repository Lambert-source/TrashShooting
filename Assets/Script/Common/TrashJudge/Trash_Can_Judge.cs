using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyGameNamespace;

public class Trash_Can_Judge : MonoBehaviour
{
    public GameObject[] balllPrefabs;

   private int count=0;

    private void OnTriggerEnter(Collider other)
    {

        // Check if the colliding object is tagged as "GreenBin"
        //Debug.Log("Collided with: " + other.gameObject.name);
        //BlueBin
        ////////Bottles
        if (other.gameObject.CompareTag("metal"))
        {
            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 30;
        }

        else if (other.gameObject.CompareTag("paper"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 20;
        }
        else if (other.gameObject.CompareTag("plastic"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 10;
        }
        else if (other.gameObject.CompareTag("glass"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 20;
        }
        else if (other.gameObject.CompareTag("pepsi"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 50;
        }
        else if (other.gameObject.CompareTag("sprite"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 60;
        }
        ////////Bottles
        ///
        else if (other.gameObject.CompareTag("plastic"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 10;

        }
        else if (other.gameObject.CompareTag("paper"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 20;
        }
        else if (other.gameObject.CompareTag("glass"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 20;
        }
        else if (other.gameObject.CompareTag("metal"))
        {
            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count + 30;
        }

        //RedBin
        else if (other.gameObject.CompareTag("paint"))
        {
            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 10;
        }
        else if (other.gameObject.CompareTag("Fluorecent_Tube"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 10;
        }
        else if (other.gameObject.CompareTag("Chemical_Residue"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 20;
        }
        else if (other.gameObject.CompareTag("Light_Bulbs"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 20;
        }
        else if (other.gameObject.CompareTag("Battery"))
        {
            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 30;
        }

        //GreenBin
        else if (other.gameObject.CompareTag("Leftover_Fruit"))
        {
            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 10;
        }
        else if (other.gameObject.CompareTag("Leftover_Food"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 10;
        }
        else if (other.gameObject.CompareTag("Leftover_Vegetable"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 20;
        }
        else if (other.gameObject.CompareTag("Leaf"))
        {

            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 20;
        }
        else if (other.gameObject.CompareTag("Bone"))
        {
            TrashJudgeManager.Instance.count = TrashJudgeManager.Instance.count - 30;
        }
        
        Destroy(other.gameObject); // Destroy the trash
        Debug.Log("SCORE : " + TrashJudgeManager.Instance.count);
    }

}
