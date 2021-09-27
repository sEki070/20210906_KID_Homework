using UnityEngine;
/// <summary>
/// 怪物類別
/// 儲存怪物資料
/// </summary>
public class Monster : MonoBehaviour
{
    
    [Header("基本資料"), Range(0, 10)]
    public float movespeed = 3.5f;
    [Range(0, 500)]
    public float attack = 100;
    [ Range(0, 5000)]
    public float hP = 350;
    [Range(0, 50)]
    public float trackRange = 30;
    public  Vector3 offsetTrack;
    [Header("掉落道具")]
    public GameObject prop;
    [Range(0,1)]
    public float ItemDropChance = 1f;
    [Header("掉落道具音效")]
    public AudioClip itemDropsound;
    [Header("受傷音效")]
    public AudioClip hurtSound;
    [Header("攻擊音效")]
    public AudioClip attackSound;

    private AudioClip audioSource;
    private AudioClip rigibody2D;
    private Animator animator;

   
    }