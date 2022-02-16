using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Middle : MonoBehaviour
{
    public Texture BackImage = null;
    private AsyncOperation async = null;
    void Start()
    {
        //����������һ�������в��ᱻ����
        DontDestroyOnLoad(this);

        //��ʼ���س���
        StartCoroutine("LoadScene");
    }

    //�첽����
    IEnumerator LoadScene()
    {
        async = SceneManager.LoadSceneAsync(GameObject.FindWithTag("NextScene").GetComponent<Text>().text);
        yield return async;
        Debug.Log("Complete!");
    }

    void OnGUI()
    {
        //�л������еı�����������ͼƬ���߶��������ߡ���
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), BackImage);

        //���ع�������ʾ���ȣ�Ҳ�����ǽ�����
        if (async != null && async.isDone == false)
        {
            GUIStyle style = new GUIStyle();
            style.fontSize = 48;
            GUI.Label(new Rect(0, 200, Screen.width, 20), async.progress.ToString("F2"), style);
        }

        //�ڼ��ؽ����󣬵����Ƿ��¸�������ģ��������"��������λ�ý�����Ϸ"
        if (async != null && async.isDone == true)
        {
            if (GUI.Button(new Rect(100, 100, 100, 100), new GUIContent("���������һ������")))
            {
                Destroy(this);
            }
        }


    }

}
