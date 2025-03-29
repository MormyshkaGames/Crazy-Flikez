using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public Animator anim;
    public int _whichSkinUsed;

    public void Awake()
    {
        _whichSkinUsed = PlayerPrefs.GetInt("whichSkinUsed", 100); // �������� �� ��������� - 0, ���� �� ���������

        anim.SetInteger("WitchSkin", _whichSkinUsed); // ������������� �������� �������� ����������� �����
    }

    public void Defolt()
    {
        _whichSkinUsed = 100;
        anim.SetInteger("WitchSkin", _whichSkinUsed);
        PlayerPrefs.SetInt("whichSkinUsed", _whichSkinUsed);
        PlayerPrefs.Save();  // ��������� ���������
    }

    public void BlueBird()
    {
        _whichSkinUsed = 1;
        anim.SetInteger("WitchSkin", _whichSkinUsed);
        PlayerPrefs.SetInt("whichSkinUsed", _whichSkinUsed);
        PlayerPrefs.Save();  // ��������� ���������
    }

    public void RedBird()
    {
        _whichSkinUsed = 2;
        anim.SetInteger("WitchSkin", _whichSkinUsed);
        PlayerPrefs.SetInt("whichSkinUsed", _whichSkinUsed);
        PlayerPrefs.Save();  // ��������� ���������
    }

    public void PiratBird()
    {
        _whichSkinUsed = 3;
        anim.SetInteger("WitchSkin", _whichSkinUsed);
        PlayerPrefs.SetInt("whichSkinUsed", _whichSkinUsed);
        PlayerPrefs.Save();  // ��������� ���������
    }

    public void HellowinBird()
    {
        _whichSkinUsed = 4;
        anim.SetInteger("WitchSkin", _whichSkinUsed);
        PlayerPrefs.SetInt("whichSkinUsed", _whichSkinUsed);
        PlayerPrefs.Save();  // ��������� ���������
    }

    public void WaterMelonBird()
    {
        _whichSkinUsed = 5;
        anim.SetInteger("WitchSkin", _whichSkinUsed);
        PlayerPrefs.SetInt("whichSkinUsed", _whichSkinUsed);
        PlayerPrefs.Save();  // ��������� ���������
    }

    public void PikaBird()
    {
        _whichSkinUsed = 6;
        anim.SetInteger("WitchSkin", _whichSkinUsed);
        PlayerPrefs.SetInt("whichSkinUsed", _whichSkinUsed);
        PlayerPrefs.Save();  // ��������� ���������
    }

    public void AsukaBird()
    {
        _whichSkinUsed = 7;
        anim.SetInteger("WitchSkin", _whichSkinUsed);
        PlayerPrefs.SetInt("whichSkinUsed", _whichSkinUsed);
        PlayerPrefs.Save();  // ��������� ���������
    }

    public void CriperBird()
    {
        _whichSkinUsed = 8;
        anim.SetInteger("WitchSkin", _whichSkinUsed);
        PlayerPrefs.SetInt("whichSkinUsed", _whichSkinUsed);
        PlayerPrefs.Save();  // ��������� ���������
    }
}
