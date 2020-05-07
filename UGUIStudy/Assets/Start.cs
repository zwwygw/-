using UnityEngine;
using UnityEngine.UI;

public class Start : MonoBehaviour {
    public Button startBut;
    public Button editorselect;
    public Button licButt;
    private BatCtrl batCtrl;
    void Awake ()
    {
        batCtrl = new BatCtrl();
        startBut.onClick.AddListener(delegate ()
        {
            OnClick(startBut.gameObject);
        });
        editorselect.onClick.AddListener(delegate ()
        {
            OnClick(editorselect.gameObject);
        });
        licButt.onClick.AddListener(delegate ()
        {
            OnClick(licButt.gameObject);
        });
	}

    void OnClick(GameObject gameObject)
    {
        if (gameObject == startBut.gameObject)
        {
            BatStart batStart = new BatStart();
            batStart.start();
        }
        if (gameObject == editorselect.gameObject)
        {
            batCtrl.SelEdi();
        }
        if (gameObject == licButt.gameObject)
        {
            batCtrl.SelLic();
        }
    }
}
