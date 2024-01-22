using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIMeneger : MonoBehaviour
{
    public RectTransform MainMenu1, MainMenu2, MainMenu3, Button, Petunjuk1, Petunjuk2, Petunjuk3, Petunjuk4;
    // Start is called before the first frame update
    void Start()
    {
        MenuMenu1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMenu2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMenu2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Petunjuk1.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Petunjuk2.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        Petunjuk3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Petunjuk4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuKembalibutton()
    {
        MenuMenu1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMenu2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMenu2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Petunjuk1.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Petunjuk2.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        Petunjuk3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Petunjuk4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuPetunjukbutton()
    {
        MenuMenu1.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        MenuMenu2.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        MenuMenu2.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        Petunjuk1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Petunjuk2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Petunjuk3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Petunjuk4.DOAnchorPos(new Vector2(0, 0), 1.0f);

    }

}
