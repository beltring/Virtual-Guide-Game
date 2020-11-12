using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingTogetherStudent : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject player;
    private bool logic;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            logic = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            logic = false;
        }
    }

    void OnGUI()
    {
        if (logic == true)
        {
            GUI.TextArea(new Rect((Screen.width / 2 - 250), (Screen.height / 2 - 100), 400, 80), "Эти студенты пишут скрипт вместе. " +
                "Издалека может показаться, " +
                "что пока один трудится, другой не делает ничего, но вблизи слышно, " +
                "как сосед по парте подсказывает, где была ошибка. " +
                "Эта методика называется 'парным программированием' и имеет широкое распространение за рубежом.");

        }

    }

}