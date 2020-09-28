using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextManager : MonoBehaviour
{
    [SerializeField] Text winText;
    [SerializeField] Text drawText;
    [SerializeField] Text loseText;
    // Start is called before the first frame update
    void Start()
    {
        winText.text = "勝ち：" + RecordWar.Instance.win;
        drawText.text = "引き分け：" + RecordWar.Instance.draw;
        loseText.text = "負け：" + RecordWar.Instance.lose;
    }

}
